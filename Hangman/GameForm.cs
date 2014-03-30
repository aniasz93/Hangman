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
            string letter = letterTB.Text;
            bool isAddedLetter = IsLetterAddedToUsedLetterList(letter);

            if (!isAddedLetter)
            {
                usedLetterLabel.Text += letter + " ";
            }
        }

        // set stopwatch
        private static System.Timers.Timer sec = null;
        private static DateTime time = new DateTime();

        private void GameForm_Load(object sender, EventArgs e)
        {
            // name choosen category
            string category = categoryLabel.Text = GameOptionsForm.Category;

            // draw word
            string wordToGuess = DrawWord(category);
            guessingWordLabel.Text = wordToGuess;

            // stopwatch
            if (sec == null)
            {
                sec = new System.Timers.Timer(1000);
                sec.SynchronizingObject = this;
                sec.Elapsed += new System.Timers.ElapsedEventHandler(SecTick);
            }
            
            sec.Start();
        }

        #endregion

        #region Methods

        private void init()
        {
            categoryLabel.Text = GameOptionsForm.Category;
        }

        // checking if letters was added to used letters list
        private bool IsLetterAddedToUsedLetterList(string letter)
        {
            bool isLetter = false;

            int i = 0;
            do
            {
                if (usedLetterLabel.Text.Length != 0)
                {
                    if (letter != usedLetterLabel.Text.Substring(i, 1))
                    {
                        i += 2;
                    }
                    else
                    {
                        isLetter = true;
                    }
                }
                else
                {
                    break;
                }
            } while (i < usedLetterLabel.Text.Length && !isLetter);

            return isLetter;
        }

        // drawing letter to guessing
        private string DrawWord(string cat)
        {
            string fileName = @"D:\Projekty\Hangman\Categories\" + cat + ".txt";
            List <string> words = new List<string>();
            string word = "";
            Random rand = new Random();
            int wordNumb = 0;

            int i = 0;

            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(fileName);
                
                do
                {
                    words.Add(objReader.ReadLine());
                    i++;
                } while (objReader.Peek() != -1);

                objReader.Close();
            }
            else
            {
                MessageBox.Show("File not found " + fileName);
            }

            wordNumb = rand.Next(i);

            int j = 0;
            do
            {
                if (j == wordNumb)
                {
                    word = words[j];
                    break;
                }
                else
                {
                    j++;
                }
            } while (j < i);

            return word;
        }


        // stopwatch ticking
        private void SecTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            time = time.AddMilliseconds(((System.Timers.Timer)sender).Interval);
            this.timeLabel.Text = time.ToLongTimeString();
        }

        #endregion
    }
}
