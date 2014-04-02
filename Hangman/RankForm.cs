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
        #region Variables

        FilesOperations file = new FilesOperations();

        #endregion

        #region Constructors

        public RankForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void easyBtn_Click(object sender, EventArgs e)
        {
            file.OpenFile(@"D:\Projekty\Hangman\Rankings\EasyRank.txt", rankTB);
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            file.OpenFile(@"D:\Projekty\Hangman\Rankings\MediumRank.txt", rankTB);
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            file.OpenFile(@"D:\Projekty\Hangman\Rankings\HardRank.txt", rankTB);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
