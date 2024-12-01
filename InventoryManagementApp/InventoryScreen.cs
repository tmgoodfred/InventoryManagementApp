using System.Data;

namespace InventoryManagementApp
{
    public partial class InventoryScreen : Form
    {
        public InventoryScreen(string dbUser, string dbPassword)
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            // Create a DataTable to hold the data
            DataTable table = new DataTable();
            table.Columns.Add("Column1", typeof(string));
            table.Columns.Add("Column2", typeof(int));
            table.Columns.Add("Column3", typeof(DateTime));

            // Add some rows to the DataTable
            table.Rows.Add("Row1", 1, DateTime.Now);
            table.Rows.Add("Row2", 2, DateTime.Now.AddDays(1));
            table.Rows.Add("Row3", 3, DateTime.Now.AddDays(2));

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = table;
        }
    }
}
