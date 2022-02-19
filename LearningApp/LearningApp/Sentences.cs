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
    public partial class Sentences : Form
    {
        Random rnd = new Random();
        int indexNumber;
        string randomSentence;
        string[] sentenceList;
        string sentencePath = System.IO.Path.GetFullPath(@"data\InformationFiles\Sentence.data.txt");

        public Sentences()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            sentenceList = System.IO.File.ReadAllLines(sentencePath);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void newSentenceButton_Click(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(sentenceList.Length);
            randomSentence = sentenceList.GetValue(indexNumber).ToString();
            textBox1.Text = randomSentence;
        }
    }
}
