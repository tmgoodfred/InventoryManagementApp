namespace InventoryManagementApp
{
    partial class ViewProductInformation
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
            productImagePB = new PictureBox();
            productNameTxt = new TextBox();
            descriptionTxt = new TextBox();
            priceTxt = new TextBox();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productImagePB).BeginInit();
            SuspendLayout();
            // 
            // productImagePB
            // 
            productImagePB.Location = new Point(64, 77);
            productImagePB.Name = "productImagePB";
            productImagePB.Size = new Size(274, 265);
            productImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
            productImagePB.TabIndex = 0;
            productImagePB.TabStop = false;
            // 
            // productNameTxt
            // 
            productNameTxt.Location = new Point(133, 48);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.ReadOnly = true;
            productNameTxt.Size = new Size(131, 23);
            productNameTxt.TabIndex = 1;
            // 
            // descriptionTxt
            // 
            descriptionTxt.Location = new Point(375, 112);
            descriptionTxt.Multiline = true;
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.ReadOnly = true;
            descriptionTxt.Size = new Size(367, 153);
            descriptionTxt.TabIndex = 2;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(499, 281);
            priceTxt.Name = "priceTxt";
            priceTxt.ReadOnly = true;
            priceTxt.Size = new Size(100, 23);
            priceTxt.TabIndex = 3;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(355, 370);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 4;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // ViewProductInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(backBtn);
            Controls.Add(priceTxt);
            Controls.Add(descriptionTxt);
            Controls.Add(productNameTxt);
            Controls.Add(productImagePB);
            Name = "ViewProductInformation";
            Text = "ViewProductInformation";
            ((System.ComponentModel.ISupportInitialize)productImagePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImagePB;
        private TextBox productNameTxt;
        private TextBox descriptionTxt;
        private TextBox priceTxt;
        private Button backBtn;
    }
}