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
    public partial class TypeForm : Form
    {
        #region Variables

        private static string typedWord = "";
        private static bool isOKClicked = false;

        #endregion

        #region Properties

        public static string TypedWord
        {
            set { typedWord = value; }
            get { return typedWord; }
        }

        public static bool IsOKClicked
        {
            set { isOKClicked = value; }
            get { return isOKClicked; }
        }

        #endregion

        #region Buttons

        public TypeForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            typedWord = typedWordTB.Text.ToLower();
            isOKClicked = true;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            isOKClicked = false;
            this.Close();
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            typedWordTB.Text = "";
        }

        #endregion
    }
}
