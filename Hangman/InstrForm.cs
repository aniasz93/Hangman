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
        #region Variables

        FilesOperations file = new FilesOperations();

        #endregion

        #region Constructors

        public InstrForm()
        {
            InitializeComponent();
            init();
        }

        #endregion

        #region Buttons

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region Methods

        private void init()
        {
            LoadInstruction();
        }

        private void LoadInstruction()
        {
            file.OpenFile(@"D:\Projekty\Hangman\Instruction.txt", instrTB);
        }

        #endregion
    }
}
