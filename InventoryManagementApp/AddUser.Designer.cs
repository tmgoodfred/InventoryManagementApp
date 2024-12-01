namespace InventoryManagementApp
{
    partial class AddUserForm
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
            usernameTxt = new TextBox();
            passwordTxt = new MaskedTextBox();
            passwordConfirmTxt = new MaskedTextBox();
            submitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            accessLevelComboBox = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(235, 61);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(218, 23);
            usernameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(235, 107);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(218, 23);
            passwordTxt.TabIndex = 1;
            // 
            // passwordConfirmTxt
            // 
            passwordConfirmTxt.Location = new Point(235, 151);
            passwordConfirmTxt.Name = "passwordConfirmTxt";
            passwordConfirmTxt.PasswordChar = '*';
            passwordConfirmTxt.Size = new Size(218, 23);
            passwordConfirmTxt.TabIndex = 2;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(269, 243);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 64);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 159);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password:";
            // 
            // accessLevelComboBox
            // 
            accessLevelComboBox.FormattingEnabled = true;
            accessLevelComboBox.Location = new Point(235, 194);
            accessLevelComboBox.Name = "accessLevelComboBox";
            accessLevelComboBox.Size = new Size(218, 23);
            accessLevelComboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 197);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Access Level:";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 353);
            Controls.Add(label4);
            Controls.Add(accessLevelComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submitBtn);
            Controls.Add(passwordConfirmTxt);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Name = "AddUserForm";
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private MaskedTextBox passwordTxt;
        private MaskedTextBox passwordConfirmTxt;
        private Button submitBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox accessLevelComboBox;
        private Label label4;
    }
}