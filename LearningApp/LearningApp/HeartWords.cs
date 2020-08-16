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
    public partial class HeartWords : Form
    {
        Random rnd = new Random();
        int indexNumber;
        string randomHeartWord, randomShortVowel;
        string[] heartList, shortVowelList;
        string heartWordPath = @"E:\VSPrograms\LearningApp\LearningApp\data\InformationFiles\WordList.data.txt";
        string shortVowelPath = @"E:\VSPrograms\LearningApp\LearningApp\data\InformationFiles\ShortVowel.data.txt";

        public HeartWords()
        {
            InitializeComponent();
            heartList = System.IO.File.ReadAllLines(heartWordPath);
            shortVowelList = System.IO.File.ReadAllLines(shortVowelPath);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void heartWordButton_Click(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(heartList.Length);
            randomHeartWord = heartList.GetValue(indexNumber).ToString();
            textBox1.Text = randomHeartWord;
        }

        private void shortVowelButton_Click(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(shortVowelList.Length);
            randomShortVowel = shortVowelList.GetValue(indexNumber).ToString();
            textBox1.Text = randomShortVowel;
        }
    }
}
