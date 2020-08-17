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
    public partial class Sounds : Form
    {
        Random rnd = new Random();
        int indexNumber;
        string[] letterList, blendList;
        string randomLetter, randomBlend;
        string letterPath = System.IO.Path.GetFullPath(@"data\InformationFiles\Sounds.data.txt");
        string blendPath = System.IO.Path.GetFullPath(@"data\InformationFiles\BlendSounds.data.txt");

        public Sounds()
        {
            InitializeComponent();
            letterList = System.IO.File.ReadAllLines(letterPath);
            blendList = System.IO.File.ReadAllLines(blendPath);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void letterButton_Click(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(letterList.Length);
            randomLetter = letterList.GetValue(indexNumber).ToString();
            textBox1.Text = randomLetter;
        }

        private void blendButton_Click(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(blendList.Length);
            randomBlend = blendList.GetValue(indexNumber).ToString();
            textBox1.Text = randomBlend;
        }

    }
}
