using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningApp
{
    public partial class Numbers : Form
    {
        Random rnd = new Random();

        public Numbers()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            int randomNumber = rnd.Next(0, 100);
            textBox1.Text = randomNumber.ToString();
        }
    }
}
