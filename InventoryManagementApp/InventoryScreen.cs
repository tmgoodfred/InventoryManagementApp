using System.Data;

namespace InventoryManagementApp
{
    public partial class InventoryScreen : Form
    {
        private readonly DatabaseFunctions _dbFunctions;

        public InventoryScreen(DatabaseFunctions dbFunctions, string userAccessLevel)
        {
            InitializeComponent();
            _dbFunctions = dbFunctions;
            LoadData();

            if (userAccessLevel == "View-Only")
            {
                AddProductBtn.Enabled = false;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen(_dbFunctions);
            addProductScreen.FormClosed += (s, args) => LoadData();
            addProductScreen.Show();
        }

        private void viewProductBtn_Click(object sender, EventArgs e)
        {
            // Get the selected row
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string productName = dataGridView1.Rows[rowIndex].Cells["ItemName"].Value.ToString();
            var selectedProduct = _dbFunctions.GetProducts().FirstOrDefault(p => p.ProductName == productName);
            if (selectedProduct != null)
            {
                ViewProductInformation viewProductInformation = new ViewProductInformation(selectedProduct);
                viewProductInformation.Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void getInventoryInformationBtn_Click(object sender, EventArgs e)
        {
            InventoryInformationScreen inventoryInformationScreen = new InventoryInformationScreen(_dbFunctions);
            inventoryInformationScreen.Show();
        }
    }
}
