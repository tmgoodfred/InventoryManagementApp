namespace InventoryManagementApp
{
    partial class InventoryInformationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryInformationScreen));
            totalProductsTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            totalValueTxt = new TextBox();
            backBtn = new Button();
            productCountTxt = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // totalProductsTxt
            // 
            totalProductsTxt.Location = new Point(248, 79);
            totalProductsTxt.Name = "totalProductsTxt";
            totalProductsTxt.ReadOnly = true;
            totalProductsTxt.Size = new Size(100, 23);
            totalProductsTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 82);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Total Products:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 122);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Total Value:";
            // 
            // totalValueTxt
            // 
            totalValueTxt.Location = new Point(248, 119);
            totalValueTxt.Name = "totalValueTxt";
            totalValueTxt.ReadOnly = true;
            totalValueTxt.Size = new Size(100, 23);
            totalValueTxt.TabIndex = 3;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(216, 178);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 4;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // productCountTxt
            // 
            productCountTxt.Location = new Point(248, 41);
            productCountTxt.Name = "productCountTxt";
            productCountTxt.ReadOnly = true;
            productCountTxt.Size = new Size(100, 23);
            productCountTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 44);
            label3.Name = "label3";
            label3.Size = new Size(169, 15);
            label3.TabIndex = 6;
            label3.Text = "Amount of Products Available:";
            // 
            // InventoryInformationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 256);
            Controls.Add(label3);
            Controls.Add(productCountTxt);
            Controls.Add(backBtn);
            Controls.Add(totalValueTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(totalProductsTxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryInformationScreen";
            Text = "InventoryInformationScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalProductsTxt;
        private Label label1;
        private Label label2;
        private TextBox totalValueTxt;
        private Button backBtn;
        private TextBox productCountTxt;
        private Label label3;
    }
}