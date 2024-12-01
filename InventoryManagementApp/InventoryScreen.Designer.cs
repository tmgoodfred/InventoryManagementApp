namespace InventoryManagementApp
{
    partial class InventoryScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RefreshBtn = new Button();
            AddProductBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(506, 698);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(101, 23);
            RefreshBtn.TabIndex = 0;
            RefreshBtn.Text = "Refresh Data";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(977, 708);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(97, 23);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1049, 669);
            dataGridView1.TabIndex = 2;
            // 
            // InventoryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 759);
            Controls.Add(dataGridView1);
            Controls.Add(AddProductBtn);
            Controls.Add(RefreshBtn);
            Name = "InventoryScreen";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button RefreshBtn;
        private Button AddProductBtn;
        private DataGridView dataGridView1;
    }
}
