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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void soundButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sounds sounds = new Sounds();
            sounds.ShowDialog();
            this.Close();
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeartWords words = new HeartWords();
            words.ShowDialog();
            this.Close();
        }

        private void sentenceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sentences sentences = new Sentences();
            sentences.ShowDialog();
            this.Close();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Numbers numbers = new Numbers();
            numbers.ShowDialog();
            this.Close();
        }

        private void mathButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Math math = new Math();
            math.ShowDialog();
            this.Close();
        }
    }
}
