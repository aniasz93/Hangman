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
        #region Variables

        Word word = new Word();
        string wordToGuess = "";
        string hiddenWord = "";
        List<string> letters = new List<string>();

        #endregion

        #region Constructors

        public GameForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void okBtn_Click(object sender, EventArgs e)
        {
            string letter = letterTB.Text;
            letter.ToLower();

            bool isLetterUsed = word.IsLetterUsedAlready(letters, letter);
            bool isLetterInWord = false;

            letters.Add(letter);
            
            if (!isLetterUsed)
            {
                isLetterInWord = word.IsLetterUsedInWord(wordToGuess, letter);

                if (isLetterInWord)
                {
                    hiddenWord = word.DiscoveryLetters(hiddenWord, wordToGuess, letter);
                }
                else
                {
                    usedLetterLabel.Text += letter + ' ';
                }

                guessingWordLabel.Text = hiddenWord;
            }
        }

        // set stopwatch
        private static System.Timers.Timer sec = null;
        private static DateTime time = new DateTime();

        private void GameForm_Load(object sender, EventArgs e)
        {
            // stopwatch
            if (sec == null)
            {
                sec = new System.Timers.Timer(1000);
                sec.SynchronizingObject = this;
                sec.Elapsed += new System.Timers.ElapsedEventHandler(SecTick);
            }

            sec.Start();


            // name choosen category
            string category = categoryLabel.Text = GameOptionsForm.Category;

            // draw word
            wordToGuess = word.DrawWord(category);

            // hide word
            guessingWordLabel.Text = hiddenWord = word.HideWord(wordToGuess);
        }

        #endregion

        #region Methods

        // stopwatch ticking
        private void SecTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            time = time.AddMilliseconds(((System.Timers.Timer)sender).Interval);
            this.timeLabel.Text = time.ToLongTimeString();
        }

        #endregion
    }
}
