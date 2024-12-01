using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagementApp
{
    public partial class AddUserForm : Form
    {
        public readonly DatabaseFunctions _dbFunctions;

        public AddUserForm(DatabaseFunctions dbFunctions)
        {
            InitializeComponent();
            _dbFunctions = dbFunctions;

            // Populate access level combo box
            accessLevelComboBox.Items.AddRange(new string[] { "Admin", "Standard", "View-Only" });
            accessLevelComboBox.SelectedIndex = 0;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var userName = usernameTxt.Text;
            var userPassword = passwordTxt.Text;
            var userPasswordConfirm = passwordConfirmTxt.Text;
            var createDate = DateTime.Now;
            var accessLevel = accessLevelComboBox.SelectedItem.ToString();

            if (userPassword != userPasswordConfirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            else if (userName == "" || userPassword == "")
            {
                MessageBox.Show("Username and password cannot be empty!");
                return;
            }
            else
            {
                // Check if user already exists
                var userExists = _dbFunctions.VerifyUser(userName, userPassword);
                if (userExists)
                {
                    MessageBox.Show("User already exists!");
                    return;
                }
                _dbFunctions.AddUser(userName, userPassword, createDate, accessLevel);
                MessageBox.Show("User added successfully!");
                this.Close();
            }
        }
    }
}

