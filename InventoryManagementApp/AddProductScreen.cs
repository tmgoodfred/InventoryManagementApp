namespace InventoryManagementApp
{
    public partial class AddProductScreen : Form
    {
        private readonly DatabaseFunctions _dbFunctions;
        byte[] imageBytes;

        public AddProductScreen(DatabaseFunctions dbFunctions)
        {
            InitializeComponent();
            _dbFunctions = dbFunctions;
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Convert the image to a byte array to store in the database
                    imageBytes = File.ReadAllBytes(filePath);

                    // Store the image bytes in a class-level variable or use them as needed
                    // _dbFunctions.AddProduct(..., imageBytes);
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Retrieve data from form fields
            string productName = productNameTxt.Text;
            string productDescription = productDescriptionTxt.Text;
            DateTime dateAdded = DateTime.Now;
            decimal productPrice = decimal.Parse(productPriceTxt.Text);
            int productQuantity = int.Parse(productQuantityTxt.Text);

            // Assuming imageBytes is a class-level variable set in addImageBtn_Click
            byte[] productImage = imageBytes;

            // Add product to the database
            _dbFunctions.AddProduct(productName, productDescription, dateAdded, productPrice, productImage);

            // Retrieve the product ID of the newly added product
            List<Product> products = _dbFunctions.GetProducts();
            int newProductId = products.Last().ProductId;

            // Add product quantity to the inventory
            Inventory newInventory = new Inventory
            {
                ProductID = newProductId,
                Quantity = productQuantity
            };
            _dbFunctions.AddInventory(newInventory);
        }
    }
}

