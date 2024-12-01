using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class InventoryInformationScreen : Form
    {
        private readonly DatabaseFunctions _dbFunctions;
        public InventoryInformationScreen(DatabaseFunctions dbFunctions)
        {
            InitializeComponent();
            _dbFunctions = dbFunctions;
            totalValueTxt.Text = _dbFunctions.GetTotalInventoryValue().ToString();
            totalProductsTxt.Text = _dbFunctions.GetTotalProductAmount().ToString();
            productCountTxt.Text = _dbFunctions.GetProductCount().ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
