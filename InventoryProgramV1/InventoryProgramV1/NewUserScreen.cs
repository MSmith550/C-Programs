using System;
using System.IO;
using System.Windows.Forms;

namespace InventoryProgramV1
{
    public partial class NewUserScreen : Form
    {
        public NewUserScreen()
        {
            InitializeComponent();     
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //switches back to previous screen
            this.Hide();
            loginScreen loginScreen = new loginScreen();
            loginScreen.ShowDialog();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //gets the username data into an array list
            string[] userList = File.ReadAllLines(Path.GetFullPath(@"data\UserNames.txt"));

            if (userList.Length > 0)
            {

                //using for each loop for checking to see if user name already exists
                for (int i = 0; i < userList.Length; i++)
                {
                    if (userList[i].Contains(textBox1.Text))
                    {
                        userConfermationText.Text = "User Already Exsits";
                        break;
                    }
                    else
                    {
                        //adds in the new user name
                        using (StreamWriter sw = File.AppendText(Path.GetFullPath(@"data\UserNames.txt")))
                        {
                            sw.WriteLine(textBox1.Text);
                            userConfermationText.Text = "User Added";
                            textBox1.Clear();
                        }
                    }
                }
            }
            else
            {
                //adds in the new user name
                using (StreamWriter sw = File.AppendText(Path.GetFullPath(@"data\UserNames.txt")))
                {
                    sw.WriteLine(textBox1.Text);
                    userConfermationText.Text = "User Added";
                    textBox1.Clear();
                }
            }
        }
    }
}
