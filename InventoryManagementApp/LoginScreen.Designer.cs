namespace InventoryManagementApp
{
    partial class LoginScreen
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
            label1 = new Label();
            label2 = new Label();
            signInBtn = new Button();
            addUserBtn = new Button();
            passwordTxt = new MaskedTextBox();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(212, 62);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(163, 23);
            usernameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // signInBtn
            // 
            signInBtn.Location = new Point(223, 148);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(75, 23);
            signInBtn.TabIndex = 4;
            signInBtn.Text = "Sign In";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += signInBtn_Click;
            // 
            // addUserBtn
            // 
            addUserBtn.Location = new Point(347, 148);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(75, 23);
            addUserBtn.TabIndex = 5;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = true;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(212, 103);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(163, 23);
            passwordTxt.TabIndex = 6;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 235);
            Controls.Add(passwordTxt);
            Controls.Add(addUserBtn);
            Controls.Add(signInBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTxt);
            Name = "LoginScreen";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private Label label1;
        private Label label2;
        private Button signInBtn;
        private Button addUserBtn;
        private MaskedTextBox passwordTxt;
    }
}