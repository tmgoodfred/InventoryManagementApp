using System.Data;

namespace InventoryManagementApp
{
    public partial class InventoryScreen : Form
    {
        private readonly DatabaseFunctions _dbFunctions;

        public InventoryScreen(DatabaseFunctions dbFunctions)
        {
            InitializeComponent();
            _dbFunctions = dbFunctions;
            LoadData();
        }

        private void LoadData()
        {
            // Create a DataTable to hold the data
            DataTable table = new DataTable();
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Date Added", typeof(DateTime));

            // Fetch data using DatabaseFunctions class
            var inventoryList = _dbFunctions.GetProductInventory();

            foreach (var item in inventoryList)
            {
                table.Rows.Add(item.ProductName, item.ProductDescription, item.Price, item.Quantity, item.DateAdded);
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = table;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen(_dbFunctions);
            addProductScreen.Show();
            LoadData();
        }
    }
}
