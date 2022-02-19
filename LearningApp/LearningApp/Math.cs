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
        int randomNumber1, randomNumber2, answer, temp, indexNumber;
        string[] mathWordsList;
        string randomMathWord;
        string mathWordsPath = System.IO.Path.GetFullPath(@"data\InformationFiles\MathWords.data.txt");

        public Math()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            mathWordsList = System.IO.File.ReadAllLines(mathWordsPath);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            randomNumber1 = rnd.Next(0, 10);
            randomNumber2 = rnd.Next(0, 10);
            if (randomNumber2 > randomNumber1)
            {
                temp = randomNumber2;
                randomNumber2 = randomNumber1;
                randomNumber1 = temp;
            }
            textBox1.Text = randomNumber1.ToString() + " - " + randomNumber2.ToString() + " = ?";
            button4.Enabled = true;
        }

        private void lessGreaterQuestionButton_Click(object sender, EventArgs e)
        {
            randomNumber1 = rnd.Next(0, 20);
            randomNumber2 = rnd.Next(0, 20);
            textBox1.Text = "is " + randomNumber1.ToString() + " Less or Greater than " + randomNumber2.ToString() + "?";
            greaterThanButton.Enabled = true;
            lessThanButton.Enabled = true;
        }

        private void greaterThanButton_Click(object sender, EventArgs e)
        {
            if (randomNumber1 > randomNumber2)
            {
                textBox1.Text = "You are correct. " + randomNumber1.ToString() + " is Greater than " + randomNumber2.ToString();
            }
            else
            {
                textBox1.Text = "That is not Correct. " + randomNumber1.ToString() + " is Less than " + randomNumber2.ToString();
            }
            greaterThanButton.Enabled = false;
            lessThanButton.Enabled = false;
        }

        private void lessThanButton_Click(object sender, EventArgs e)
        {
            if (randomNumber1 < randomNumber2)
            {
                textBox1.Text = "You are correct. " + randomNumber1.ToString() + " is Less than " + randomNumber2.ToString();
            }
            else
            {
                textBox1.Text = "That is not Correct. " + randomNumber1.ToString() + " is Greater than " + randomNumber2.ToString();
            }
            greaterThanButton.Enabled = false;
            lessThanButton.Enabled = false;
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(mathWordsList.Length);
            randomMathWord = mathWordsList.GetValue(indexNumber).ToString();
            textBox1.Text = randomMathWord;
        }

        private void subtractionAnswer_Click(object sender, EventArgs e)
        {
            answer = randomNumber1 - randomNumber2;
            textBox1.Text = "Answer is: " + answer;
            button4.Enabled = false;
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
