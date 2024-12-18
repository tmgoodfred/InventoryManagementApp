﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace InventoryManagementApp
{
    public class DatabaseFunctions
    {
        private readonly string dbUser;
        private readonly string dbPassword;
        private readonly string connectionString;

        public DatabaseFunctions(IOptions<Secrets> options)
        {
            var secrets = options.Value;
            dbUser = secrets.dbUser;
            dbPassword = secrets.dbPassword;

            // Debugging: Check if secrets are null
            if (dbUser == null || dbPassword == null)
            {
                throw new Exception("User secrets not found. Ensure that the secrets are correctly set in secrets.json.");
            }

            connectionString = $"Server=192.168.1.217;Database=InventoryManagement;User ID={dbUser};Password={dbPassword};";

            // Initialize the database connection
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Connection is successful if no exception is thrown
            }
        }

        public void AddProduct(string productName, string productDescription, DateTime dateAdded, decimal productPrice, byte[] productImage)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO ProductData (ProductName, ProductDescription, DateAdded, ProductPrice, ProductImage) VALUES (@ProductName, @ProductDescription, @DateAdded, @ProductPrice, @ProductImage)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductDescription", productDescription);
                    command.Parameters.AddWithValue("@DateAdded", dateAdded);
                    command.Parameters.AddWithValue("@ProductPrice", productPrice);
                    command.Parameters.AddWithValue("@ProductImage", productImage);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM ProductData";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                ProductId = reader.GetInt32("ProductID"),
                                ProductName = reader.GetString("ProductName"),
                                ProductDescription = Encoding.UTF8.GetString((byte[])reader["ProductDescription"]), // Corrected line
                                DateAdded = reader.GetDateTime("DateAdded"),
                                Price = reader.GetDecimal("ProductPrice"),
                                ProductImage = (byte[])reader["ProductImage"]
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        public List<Inventory> GetInventory()
        {
            var inventory = new List<Inventory>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Inventory";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Inventory
                            {
                                ProductID = reader.GetInt32("ProductID"),
                                Quantity = reader.GetInt32("ProductAmount")
                            };
                            inventory.Add(item);
                        }
                    }
                }
            }
            return inventory;
        }



        public void AddInventory(Inventory item)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO Inventory (ProductID, ProductAmount) VALUES (@ProductID, @ProductAmount)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", item.ProductID);
                    command.Parameters.AddWithValue("@ProductAmount", item.Quantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddUser(string userName, string userPassword, DateTime createDate, string accessLevel)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO UserData (UserName, UserPassword, CreateDate, AccessLevel) VALUES (@UserName, @UserPassword, @CreateDate, @AccessLevel)";
                using (var command = new MySqlCommand(query, connection))
                {
                    var encryptedPassword = EncryptPassword(userPassword);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserPassword", encryptedPassword);
                    command.Parameters.AddWithValue("@CreateDate", createDate);
                    command.Parameters.AddWithValue("@AccessLevel", accessLevel);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool VerifyUser(string userName, string userPassword)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT UserPassword FROM UserData WHERE UserName = @UserName";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    var storedPassword = command.ExecuteScalar() as string;

                    if (storedPassword != null)
                    {
                        var encryptedPassword = EncryptPassword(userPassword);
                        return storedPassword == encryptedPassword;
                    }
                }
            }
            return false;
        }



        private string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public List<ProductInventory> GetProductInventory()
        {
            var productInventoryList = new List<ProductInventory>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = @"
            SELECT p.ProductID, p.ProductName, p.ProductDescription, p.DateAdded, p.ProductPrice, p.ProductImage, i.ProductAmount
            FROM ProductData p
            JOIN Inventory i ON p.ProductID = i.ProductID";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productInventory = new ProductInventory
                            {
                                ProductId = reader.GetInt32("ProductID"),
                                ProductName = reader.GetString("ProductName"),
                                ProductDescription = Encoding.UTF8.GetString((byte[])reader["ProductDescription"]), // Corrected line
                                DateAdded = reader.GetDateTime("DateAdded"),
                                Price = reader.GetDecimal("ProductPrice"),
                                ProductImage = (byte[])reader["ProductImage"],
                                Quantity = reader.GetInt32("ProductAmount")
                            };
                            productInventoryList.Add(productInventory);
                        }
                    }
                }
            }
            return productInventoryList;
        }
        public string GetUserAccessLevel(string userName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT AccessLevel FROM UserData WHERE UserName = @UserName";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    var accessLevel = command.ExecuteScalar() as string;
                    return accessLevel;
                }
            }
        }
        public int GetTotalProductAmount()
        {
            int totalAmount = 0;
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT SUM(ProductAmount) FROM Inventory";
                using (var command = new MySqlCommand(query, connection))
                {
                    totalAmount = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return totalAmount;
        }
        public decimal GetTotalInventoryValue()
        {
            decimal totalValue = 0;
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT SUM(p.ProductPrice * i.ProductAmount) AS TotalValue
                    FROM ProductData p
                    JOIN Inventory i ON p.ProductID = i.ProductID";
                using (var command = new MySqlCommand(query, connection))
                {
                    totalValue = Convert.ToDecimal(command.ExecuteScalar());
                }
            }
            return totalValue;
        }
        public int GetProductCount()
        {
            int productCount = 0;
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM ProductData";
                using (var command = new MySqlCommand(query, connection))
                {
                    productCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return productCount;
        }
        public void UpdateUserLastSignIn(string userName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "UPDATE UserData SET LastSignIn = @LastSignIn WHERE UserName = @UserName";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LastSignIn", DateTime.Now);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
