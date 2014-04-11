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
    public partial class NameForm : Form
    {
        #region Variables

        GameOptionsForm gameOptionsForm = new GameOptionsForm();

        private static string name = "";
        private int age = 0;
        private static string color = "";

        #endregion

        #region Properties

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static string Color
        {
            get { return color; }
            set { color = value; }
        }

        #endregion

        #region Constructors

        public NameForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // check if there is a value in name text box
            name = nameTB.Text;
            age = int.Parse(ageTB.Text);

            // checking what color is favourite one
            bool isColor = false;

            if (blueRadioBtn.Checked)
            {
                isColor = true;
                color = blueRadioBtn.Text;
            }
            else if (redRadioBtn.Checked)
            {
                isColor = true;
                color = redRadioBtn.Text;
            }
            else if (yellowRadioBtn.Checked)
            {
                isColor = true;
                color = yellowRadioBtn.Text;
            }
            else if (greenRadioBtn.Checked)
            {
                isColor = true;
                color = greenRadioBtn.Text;
            }
            //else
            //{
            //    MessageBox.Show("You must choose your favourite color.");
            //}

            // check if all boxes are fill in and change form to next
            //if (isColor)
            //{
                this.Hide();
                gameOptionsForm.ShowDialog();
            //}
        }

        #endregion

        #region Events

        private void nameTB_Leave(object sender, EventArgs e)
        {
            if (nameTB.Text == "")
            {
                MessageBox.Show("You must fill in name text box.");
                nameTB.Focus();
            }
        }

        private void ageTB_Leave(object sender, EventArgs e)
        {
            if (ageTB.Text == "")
            {
                MessageBox.Show("You must fill in age text box.");
                ageTB.Focus();
            }
        }

        #endregion

    }
}
