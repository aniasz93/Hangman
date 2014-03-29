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
    public partial class GameForm : Form
    {
        #region Constructors

        public GameForm()
        {
            InitializeComponent();
            init();
        }

        #endregion

        #region Buttons

        private void okBtn_Click(object sender, EventArgs e)
        {
            // add letters to used letters list
            string letter;

            letter = letterTB.Text;
            usedLetterLabel.Text += " " + letter;
        }

        // set stopwatch
        private static System.Timers.Timer sek = null;
        private static DateTime time = new DateTime();

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (sek == null)
            {
                sek = new System.Timers.Timer(1000);
                sek.SynchronizingObject = this;
                sek.Elapsed += new System.Timers.ElapsedEventHandler(sek_Tick);
            }
            
            sek.Start();
        }

        #endregion

        #region Methods

        private void init()
        {
            categoryLabel.Text = GameOptionsForm.Category;
        }

        // stopwatch ticking
        private void sek_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            time = time.AddMilliseconds(((System.Timers.Timer)sender).Interval);
            this.timeLabel.Text = time.ToLongTimeString();
        }

        #endregion
    }
}
