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
    public partial class OpenForm : Form
    {
        #region Variables

        InstrForm instrForm = new InstrForm();
        RankForm rankForm = new RankForm();
        NameForm nameForm = new NameForm();

        #endregion

        #region Constructors

        public OpenForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            nameForm.ShowDialog();
            this.Show();
        }

        // turn on instruction
        private void instrBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            instrForm.ShowDialog();
            this.Show();
        }

        // turn on ranking
        private void rankBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            rankForm.ShowDialog();
            this.Show();
        }

        // close application
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
