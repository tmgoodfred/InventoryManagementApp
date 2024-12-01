namespace InventoryManagementApp
{
    partial class AddProductScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productNameTxt = new TextBox();
            productDescriptionTxt = new TextBox();
            productPriceTxt = new TextBox();
            addImageBtn = new Button();
            submitBtn = new Button();
            productQuantityTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // productNameTxt
            // 
            productNameTxt.Location = new Point(151, 35);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(204, 23);
            productNameTxt.TabIndex = 0;
            // 
            // productDescriptionTxt
            // 
            productDescriptionTxt.Location = new Point(151, 74);
            productDescriptionTxt.Multiline = true;
            productDescriptionTxt.Name = "productDescriptionTxt";
            productDescriptionTxt.Size = new Size(367, 107);
            productDescriptionTxt.TabIndex = 1;
            // 
            // productPriceTxt
            // 
            productPriceTxt.Location = new Point(151, 199);
            productPriceTxt.Name = "productPriceTxt";
            productPriceTxt.Size = new Size(111, 23);
            productPriceTxt.TabIndex = 2;
            // 
            // addImageBtn
            // 
            addImageBtn.Location = new Point(151, 238);
            addImageBtn.Name = "addImageBtn";
            addImageBtn.Size = new Size(84, 23);
            addImageBtn.TabIndex = 3;
            addImageBtn.Text = "Add Image";
            addImageBtn.UseVisualStyleBackColor = true;
            addImageBtn.Click += addImageBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(280, 326);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // productQuantityTxt
            // 
            productQuantityTxt.Location = new Point(151, 277);
            productQuantityTxt.Name = "productQuantityTxt";
            productQuantityTxt.Size = new Size(111, 23);
            productQuantityTxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 38);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 6;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 7;
            label2.Text = "Product Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 202);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 242);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 9;
            label4.Text = "Product Image:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 280);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 10;
            label5.Text = "Product Quantity:";
            // 
            // AddProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 394);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productQuantityTxt);
            Controls.Add(submitBtn);
            Controls.Add(addImageBtn);
            Controls.Add(productPriceTxt);
            Controls.Add(productDescriptionTxt);
            Controls.Add(productNameTxt);
            Name = "AddProductScreen";
            Text = "AddProductScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox productNameTxt;
        private TextBox productDescriptionTxt;
        private TextBox productPriceTxt;
        private Button addImageBtn;
        private Button submitBtn;
        private TextBox productQuantityTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}