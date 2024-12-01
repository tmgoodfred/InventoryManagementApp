namespace InventoryManagementApp
{
    public partial class LoginScreen : Form
    {
        private readonly DatabaseFunctions _dbFunctions;

        public LoginScreen(DatabaseFunctions dbFunctions)
        {
            InitializeComponent();
            _dbFunctions = dbFunctions;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            bool signIn = _dbFunctions.VerifyUser(usernameTxt.Text, passwordTxt.Text);
            if (signIn)
            {
                // Open inventory screen
                string userAccessLevel = _dbFunctions.GetUserAccessLevel(usernameTxt.Text);
                InventoryScreen inventoryScreen = new InventoryScreen(_dbFunctions, userAccessLevel);
                inventoryScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            // Open add user form
            var addUserForm = new AddUserForm(_dbFunctions);
            this.Hide();
            addUserForm.ShowDialog();
            this.Show();
        }
    }
}
