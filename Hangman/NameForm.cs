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
        private string sex = "";
        private int color;

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

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int Color
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
            bool isName = false;
            name = nameTB.Text;
            
            if (name == "")
            {
                isName = false;
                MessageBox.Show("You must fill in name text box.");
            }
            else
            {
                isName = true;
            }

            // check if there is a value in age text box
            int outputValue = 0;
            bool isAge = false;

            isAge = int.TryParse(ageTB.Text, out outputValue);

            if (isAge)
            {
                age = int.Parse(ageTB.Text);
            }
            else
            {
                MessageBox.Show("You must fill in age box.");
            }

            // checking what sex the player is
            bool isSex = false; 

            if (girlRadioBtn.Checked)
            {
                isSex = true;
                sex = girlRadioBtn.Text;
            }
            else if (boyRadioBtn.Checked)
            {
                isSex = true;
                sex = boyRadioBtn.Text;
            }
            else
            {
                MessageBox.Show("You must choose your sex.");
            }

            // checking what color is favourite one
            bool isColor = false;

            if (blueRadioBtn.Checked)
            {
                isColor = true;
                color = 0;
            }
            else if (redRadioBtn.Checked)
            {
                isColor = true;
                color = 1;
            }
            else if (yellowRadioBtn.Checked)
            {
                isColor = true;
                color = 2;
            }
            else if (greenRadioBtn.Checked)
            {
                isColor = true;
                color = 3;
            }
            else
            {
                MessageBox.Show("You must choose your favourite color.");
            }

            // check if all boxes are fill in and change form to next
            if (isName && isAge && isSex && isColor)
            {
                this.Hide();
                gameOptionsForm.ShowDialog();
            }
        }

        #endregion
    }
}
