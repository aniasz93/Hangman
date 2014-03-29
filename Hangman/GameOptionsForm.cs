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
    public partial class GameOptionsForm : Form
    {
        GameForm gameForm = new GameForm();

        #region Variables

        int lang = 0;
        static string category = "";
        string difficulty = "";

        #endregion

        #region Properties

        public int Language
        {
            get { return lang; }
            set { lang = value; }
        }

        public static string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        #endregion

        #region Constructors

        public GameOptionsForm()
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
            // checking what language the player want
            bool isLang = false;

            if (polishRadioBtn.Checked)
            {
                isLang = true;
                lang = 0;
            }
            else if (englishRadioBtn.Checked)
            {
                isLang = true;
                lang = 1;
            }
            else
            {
                MessageBox.Show("You must choose language of the password.");
            }

            // checking what category the player want
            bool isCategory = false;

            if (colorsRadioBtn.Checked)
            {
                isCategory = true;
                category = colorsRadioBtn.Text;
            }
            else if (cartoonCharsRadioBtn.Checked)
            {
                isCategory = true;
                category = cartoonCharsRadioBtn.Text;
            }
            else if (cartoonTitlesRadioBtn.Checked)
            {
                isCategory = true;
                category = cartoonTitlesRadioBtn.Text;
            }
            else if (mathRadioBtn.Checked)
            {
                isCategory = true;
                category = mathRadioBtn.Text;
            }
            else
            {
                MessageBox.Show("You must choose category.");
            }

            // check if diffuculty is choosen
            bool isDifficulty = false;

            if (easyRadioBtn.Checked)
            {
                isDifficulty = true;
                difficulty = easyRadioBtn.Text;
            }
            else if (mediumRadioBtn.Checked)
            {
                isDifficulty = true;
                difficulty = mediumRadioBtn.Text;
            }
            else if (hardRadioBtn.Checked)
            {
                isDifficulty = true;
                difficulty = hardRadioBtn.Text;
            }
            else
            {
                MessageBox.Show("You must choose difficulty.");
            }

            // check if all boxes are fill in and change form to next
            if (isLang && isCategory && isDifficulty)
            {
                this.Hide();
                gameForm.ShowDialog();
            }
        }

        #endregion
    }
}
