﻿using System;
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
        FilesOperations file = new FilesOperations();

        private string wordToGuess = "";
        private string hiddenWord = "";
        private string endTime = "";
        private string category = "";

        List<string> letters = new List<string>();

        private string name = "";
        private string fileName = "";

        // set stopwatch
        private static System.Timers.Timer sec = null;
        private static DateTime time = new DateTime();

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
            
            // check if letter was used already
            if (!isLetterUsed)
            {
                isLetterInWord = word.IsLetterUsedInWord(wordToGuess, letter);

                // check if letter is in word
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

            // check whether the game is over
            CheckIfGameIsOver();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            name = NameForm.Name;
            fileName = @"D:\Projekty\Hangman\Rankings\" + GameOptionsForm.Difficulty + "Rank.txt";

            // name choosen category
            category = categoryLabel.Text = GameOptionsForm.Category;

            // draw word
            wordToGuess = word.DrawWord(category);

            // hide word
            guessingWordLabel.Text = hiddenWord = word.HideWord(wordToGuess);

            // stopwatch
            Stopwatch();

            sec.Start();
        }

        #endregion

        #region Methods

        // stopwatch ticking
        private void SecTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            time = time.AddMilliseconds(((System.Timers.Timer)sender).Interval);
            this.timeLabel.Text = time.ToLongTimeString();
        }

        private void Stopwatch()
        {
            if (sec == null)
            {
                sec = new System.Timers.Timer(1000);
                sec.SynchronizingObject = this;
                sec.Elapsed += new System.Timers.ElapsedEventHandler(SecTick);
            }
        }

        private void CheckIfGameIsOver()
        {
            if (word.IsGuessed(hiddenWord))
            {
                Stopwatch();
                sec.Stop();

                endTime = timeLabel.Text;
                file.WriteToFile(fileName, name, endTime, category);

                MessageBox.Show(name + ", you WIN!\n You did it in: " + endTime);
                letters.Clear();
                usedLetterLabel.Text = "";
                letterTB.Text = "";
                this.Close();
            }
        }

        #endregion
    }
}
