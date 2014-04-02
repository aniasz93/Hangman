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

        // checking if letter is in word
        public bool IsLetterUsedInWord(string wordToGuess, string letter)
        {
            bool isLetter = false;

            int i = 0;
            do
            {
                if (wordToGuess.Substring(i, 1) != letter)
                {
                    i++;
                }
                else
                {
                    isLetter = true;
                }
            } while (i < wordToGuess.Count() && !isLetter);

            return isLetter;
        }

        // drawing letter to guessing
        public string DrawWord(string cat)
        {
            string fileName = @"D:\Projekty\Hangman\Categories\" + cat + ".txt";
            List<string> words = new List<string>();
            string word = "";
            Random rand = new Random();
            int wordNumb = 0;

            int i = 0;

            // adding words to guess to the list
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

            // looking for drawn word in list
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

            return word.ToLower();
        }

        // replace guessing word with '?'
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
        public string DiscoveryLetters(string hiddenWord, string wordToGuess, string letter)
        {
            string newWord = "";
            List<int> placesOfLetter = new List<int>();

            // add places where the letter is to the list, when the letter isn't on the place, -1 is added to the list
            int i = 0;
            while (i < wordToGuess.Count())
            {
                if (wordToGuess.Substring(i, 1) == letter)
                {
                    placesOfLetter.Add(i);
                }
                else
                {
                    placesOfLetter.Add(-1);
                }
                i++;
            }

            // the word is "copied" to new word with changed "?" with the letter if  the one was found
            for (int j = 0; j < wordToGuess.Count(); j++)
            {
                if (j != placesOfLetter[j])
                {
                    newWord += hiddenWord[j];
                }
                else
                {
                    newWord += letter;
                }
            }

            return newWord;
        }
        
        // check if there is some unguessed letters
        public bool IsGuessed(string hiddenWord)
        {
            for (int i = 0; i < hiddenWord.Count(); i++)
            {
                if (hiddenWord[i] == '?')
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}
