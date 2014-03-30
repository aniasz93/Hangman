using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class RankForm : Form
    {
        public RankForm()
        {
            InitializeComponent();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Projekty\Hangman\Rankings\EasyRank.txt";

            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(fileName);
                rankTB.Text = objReader.ReadToEnd();
                objReader.Close();
            }
            else
            {
                MessageBox.Show("File not found " + fileName);
            }
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Projekty\Hangman\Rankings\MediumRank.txt";

            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(fileName);
                rankTB.Text = objReader.ReadToEnd();
                objReader.Close();
            }
            else
            {
                MessageBox.Show("File not found " + fileName);
            }
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Projekty\Hangman\Rankings\HardRank.txt";

            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(fileName);
                rankTB.Text = objReader.ReadToEnd();
                objReader.Close();
            }
            else
            {
                MessageBox.Show("File not found " + fileName);
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
