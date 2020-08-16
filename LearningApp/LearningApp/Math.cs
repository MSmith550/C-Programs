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
    public partial class Math : Form
    {
        Random rnd = new Random();
        int randomNumber1, randomNumber2, answer;

        public Math()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void mathQuestionButton_Click(object sender, EventArgs e)
        {
            randomNumber1 = rnd.Next(0, 10);
            randomNumber2 = rnd.Next(0, 10);
            textBox1.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = ?";
            mathAnswerButton.Enabled = true;
        }

        private void mathAnswerButton_Click(object sender, EventArgs e)
        {
            answer = randomNumber1 + randomNumber2;
            textBox1.Text = "Answer is: " + answer;
            mathAnswerButton.Enabled = false;
        }
    }
}
