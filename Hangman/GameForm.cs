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
        private const int TRIALS = 9;

        #region Variables

        TypeForm typeForm = new TypeForm();
        Word word = new Word();
        FilesOperations file = new FilesOperations();

        private string favouriteColor = "";
        private string wordToGuess = "";
        private string hiddenWord = "";
        private string endTime = "";
        private string category = "";
        private string language = "";
        private string difficulty = "";
        private int badLetters = 0;

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
            Game();
            letterTB.Text = "";
        }

        private void letterTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Game();
                letterTB.Text = "";
                //ActiveForm.AcceptButton = okBtn;
            }
        }

        private void typeBtn_Click(object sender, EventArgs e)
        {
            typeForm.ShowDialog();
        }

        // ******** DOESN'T WORK LIKE I THINK IT SHOULD ********
        //private void letterTB_TextChanged(object sender, EventArgs e)
        //{
        //    if (System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z]", letterTB.Text))
        //    {
        //        MessageBox.Show("This textbox accepts only alphabetical characters");
        //        letterTB.Text = "";
        //    }
        //}

        private void GameForm_Load(object sender, EventArgs e)
        {
            //SetBackgroundColor();

            //name = NameForm.Name;
            //fileName = @"D:\Projekty\Hangman\Rankings\" + GameOptionsForm.Difficulty + "Rank.txt";

            //// name choosen category
            //category = categoryLabel.Text = GameOptionsForm.Category;

            //// choosen language od the word
            //language = GameOptionsForm.Language;

            //// draw word
            //wordToGuess = word.DrawWord(category, language);

            //// hide word
            //hiddenWord = word.HideWord(wordToGuess);

            //// check difficulty
            //difficulty = GameOptionsForm.Difficulty;
            //guessingWordLabel.Text = hiddenWord = word.DiscoverLetterByDifficulty(wordToGuess, hiddenWord, difficulty);
            Load();
            // stopwatch
            Stopwatch();

            sec.Start();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        // load
        private void Load()
        {
            SetBackgroundColor();

            name = NameForm.Name;
            fileName = @"D:\Projekty\Hangman\Rankings\" + GameOptionsForm.Difficulty + "Rank.txt";

            // name choosen category
            category = categoryLabel.Text = GameOptionsForm.Category;

            // choosen language od the word
            language = GameOptionsForm.Language;

            // draw word
            wordToGuess = word.DrawWord(category, language);

            // hide word
            hiddenWord = word.HideWord(wordToGuess);

            // check difficulty
            difficulty = GameOptionsForm.Difficulty;
            guessingWordLabel.Text = hiddenWord = word.DiscoverLetterByDifficulty(wordToGuess, hiddenWord, difficulty);
        }

        // enter the letters
        private void Game()
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
                    hiddenWord = word.DiscoverLetters(hiddenWord, wordToGuess, letter);
                }
                else
                {
                    usedLetterLabel.Text += letter + ' ';
                    badLetters++;

                    // check if player hasn't used all trials
                    if (badLetters > TRIALS - 1)
                    {
                        PlayerLoose();
                    }
                }

                guessingWordLabel.Text = hiddenWord;
            }

            // check whether the game is over
            CheckIfPlayerWin();
        }

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

        // checking if all of the letters was guessed
        private void CheckIfPlayerWin()
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
                badLetters = 0;
                this.Close();
            }
        }

        private void PlayerLoose()
        {
            Stopwatch();
            sec.Stop();

            MessageBox.Show(name + ", unfortunately you LOOSE!\n Looking expresion was: " + wordToGuess.ToUpper());
            letters.Clear();
            wordToGuess = "";
            usedLetterLabel.Text = "";
            letterTB.Text = "";
            badLetters = 0;
            this.Close();
        }

        // set background color by the favourite color
        private void SetBackgroundColor()
        {
            favouriteColor = NameForm.Color;
            string backgroundColor = "";

            switch (favouriteColor){
                case "red":
                    backgroundColor = "#FFB1AB";
                    break;
                case "blue":
                    backgroundColor = "#B7CBFF";
                    break;
                case "yellow":
                    backgroundColor = "#FFFAC3";
                    break;
                case "green":
                    backgroundColor = "#D0FFC5";
                    break;
                default:
                    break;
            }

            this.BackColor = ColorTranslator.FromHtml(backgroundColor);

        }

        #endregion
    }
}
