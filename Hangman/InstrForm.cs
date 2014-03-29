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
    public partial class InstrForm : Form
    {
        public InstrForm()
        {
            InitializeComponent();
            init();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void init()
        {
            LoadInstruction();
        }

        private void LoadInstruction()
        {
            string fileName = @"E:\Dropbox\My DB\Projekty\Hangman\Instruction.txt";

            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(fileName);
                instrTB.Text = objReader.ReadToEnd();
                objReader.Close();
            }
            else
            {
                MessageBox.Show("File not found " + fileName);
            }
        }
    }
}
