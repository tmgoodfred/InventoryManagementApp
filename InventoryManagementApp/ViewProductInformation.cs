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
    public partial class ViewProductInformation : Form
    {
        private Product selectedProduct;

        public ViewProductInformation(Product product)
        {
            InitializeComponent();
            selectedProduct = product;
            PopulateProductInformation();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PopulateProductInformation()
        {
            productNameTxt.Text = selectedProduct.ProductName;
            descriptionTxt.Text = selectedProduct.ProductDescription;
            priceTxt.Text = selectedProduct.Price.ToString("C");
            productImagePB.Image = ConvertByteArrayToImage(selectedProduct.ProductImage);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
