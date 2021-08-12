using System;
using System.Windows.Forms;

namespace InventoryProgramV1
{

    public partial class loginScreen : Form
    {
        public static string typedUserName = "";

        public loginScreen()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //assigns the typed in username to string for verification
            typedUserName = textBox1.Text;
            //makes a string array from the user names file to check to see if the user name exists
            string[] userList = System.IO.File.ReadAllLines(System.IO.Path.GetFullPath(@"data\UserNames.txt"));

            foreach (string user in userList){
                if (user.Equals(typedUserName, StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Hide();
                    SelectScreen selectScreen = new SelectScreen();
                    selectScreen.ShowDialog();
                    this.Close();
                }
                else
                {
                    errorMessageText.Text = "User Not On File";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserScreen newUserScreen = new NewUserScreen();
            newUserScreen.ShowDialog();
            this.Close();
        }
    }
}
