using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace InventoryProgramV1
{
    public partial class DisplayScreen : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public DisplayScreen()
        {
            InitializeComponent();
            userName.Text = loginScreen.typedUserName;
            tableName.Text = SelectScreen.userTable;

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            displayTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //switches back to previous screen
            this.Hide();
            SelectScreen selectScreen = new SelectScreen();
            selectScreen.ShowDialog();
            this.Close();
        }

        private void displayTable()
        {
            try
            {
                // Connection string as StateUser on localhost 
                String connectionString = "Data Source=localhost; Initial Catalog=InventoryProgram; User id=InvMain; Password=P@ssw0rd1;";

                // quert string for getting the table names from the database
                String queryTable = "SELECT * FROM " + SelectScreen.userTable;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(queryTable, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string as StateUser on localhost 
                String connectionString = "Data Source=localhost; Initial Catalog=InventoryProgram; User id=InvMain; Password=P@ssw0rd1;";

                // quert string for getting the table names from the database
                String queryTable = "Insert Into " + SelectScreen.userTable + " Values ('" + 
                    itemBox.Text + "', " +
                    int.Parse(upcBox.Text) + ", " +
                    int.Parse(stockBox.Text) + ");";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(queryTable, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

            RefreshTable();

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string as StateUser on localhost 
                String connectionString = "Data Source=localhost; Initial Catalog=InventoryProgram; User id=InvMain; Password=P@ssw0rd1;";

                // quert string for getting the table names from the database
                String queryTable = "Delete From " + SelectScreen.userTable + " Where ItemID = " + int.Parse(itemIDBox.Text) + ";";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(queryTable, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

            RefreshTable();

        }

        private void RefreshTable()
        {
            try
            {
                // Connection string as StateUser on localhost 
                String connectionString = "Data Source=localhost; Initial Catalog=InventoryProgram; User id=InvMain; Password=P@ssw0rd1;";

                // quert string for getting the table names from the database
                String queryTable = "SELECT * FROM " + SelectScreen.userTable;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(queryTable, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }
}
