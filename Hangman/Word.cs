using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    class Word
    {
        #region Methods

        // checking if letter was used already
        public bool IsLetterUsedAlready(List<string> letters, string letter)
        {
            bool isLetter = false;

            int i = 0;
            while (i < letters.Count() && !isLetter)
            {
                if (letters[i] == letter)
                {
                    isLetter = true;
                }
                else
                {
                    i++;
                }
            }

            return isLetter;
        }

        //public bool IsLetterOnUsedLettersList(string letter, Label usedLetters, string wordToGuess)
        //{
        //    bool isLetter = false;

        //    int i = 0;
        //    do
        //    {
        //        if (wordToGuess.Substring(i, 1) != letter)
        //        {
        //            i++;
        //        }
        //        else
        //        {
        //            isLetter = true;
        //        }
        //    } while (i < wordToGuess.Count() && !isLetter);

        //    int j = 0;
        //    while (j < usedLetters.Text.Length && !isLetter)
        //    {
        //        if (usedLetters.Text.Length != 0)
        //        {
        //            if (usedLetters.Text.Substring(j, 1) != letter)
        //            {
        //                j += 2;
        //            }
        //            else
        //            {
        //                isLetter = true;
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    return isLetter;
        //}

        // drawing letter to guessing
        public string DrawWord(string cat)
        {
            string fileName = @"D:\Projekty\Hangman\Categories\" + cat + ".txt";
            List<string> words = new List<string>();
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

        // replace guessing word with '_'
        public string HideWord(string word)
        {
            int numbOfLetters = word.Count();

            for (int i = 0; i < numbOfLetters; i++)
            {
                if (word[i] != ' ')
                {
                    word = word.Replace(word[i], '?');
                }
                else
                {

                }
            }

            return word;
        }

        // discovery of letters
        public string DiscoveryLetters(string hiddenWord, string wordToGuess, string letter, bool isLetterUsed, Label usedLetterLabel)
        {
            if (isLetterUsed)
            {
                return hiddenWord;
            }

            for (int i = 0; i < wordToGuess.Count(); i++)
            {
                if (wordToGuess.Substring(i, 1) == letter)
                {
                    hiddenWord = hiddenWord.Replace(hiddenWord.Substring(i, 1), letter);
                    isLetterUsed = true;
                }
            }

            if (!isLetterUsed)
            {
                usedLetterLabel.Text += letter + " ";
            }

            return hiddenWord;
        }

        #endregion
    }
}
