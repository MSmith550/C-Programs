using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryProgramV1
{
    public partial class SelectScreen : Form
    {
        public static string userTable = "";

        public SelectScreen()
        {
            InitializeComponent();
            userName.Text = loginScreen.typedUserName;
            LoadComboBox();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //switches back to previous screen
            this.Hide();
            loginScreen loginScreen = new loginScreen();
            loginScreen.ShowDialog();
            this.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            userTable = selectTableComboBox.Items[selectTableComboBox.SelectedIndex].ToString();
            //switches to the DisplayScreen screen
            this.Hide();
            DisplayScreen displayScreen = new DisplayScreen();
            displayScreen.ShowDialog();
            this.Close();
        }

        private void newTable_Click(object sender, EventArgs e)
        {
            //switches to the newTable screen
            this.Hide();
            NewTableScreen newTableScreen = new NewTableScreen();
            newTableScreen.ShowDialog();
            this.Close();
        }

        private void LoadComboBox()
        {
            // Connection string as StateUser on localhost 
            String connectionString = "Data Source=localhost; Initial Catalog=InventoryProgram; User id=InvMain; Password=P@ssw0rd1;";

            // quert string for getting the table names from the database
            String queryComboBox = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

            //connection to the database to fill the combo box with the tables
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand com = new SqlCommand(queryComboBox, connection))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        selectTableComboBox.Items.Clear();
                        while (reader.Read())
                        {
                            selectTableComboBox.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
        }
    }
}
