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
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("LastUpdated", typeof(DateTime));

            // Fetch data using DatabaseFunctions class
            var inventoryList = _dbFunctions.GetInventory();

            foreach (var item in inventoryList)
            {
                table.Rows.Add(item.ProductID, item.Quantity, DateTime.Now); // Assuming LastUpdated is DateTime.Now for simplicity
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = table;
        }
    }
}
