using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    class Word
    {
        #region Methods public

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
            }

            return word;
        }

        // discovery of letters
        public string DiscoverLetters(string hiddenWord, string wordToGuess, string letter)
        {
            string newWord = "";
            List<int> placesOfLetter = new List<int>();
            placesOfLetter = AddPlacesOfLetterOccuranceToList(wordToGuess, letter);

            // the word is "copied" to new word with changed "?" with the letter if the one was found
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
        
        // check which difficulty user have choosen and whichever discovers letters by function call
        public string DiscoverLetterByDifficulty(string word, string hiddenWord, string diff)
        {
            int numbOfLetters = word.Count();
            int amount = 0;

            switch (diff)
            {
                case "Easy":
                    amount = 3;
                    break;

                case "Medium":
                    amount = 1;
                    break;

                default:
                    amount = 0;
                    break;
            }

            int n;          
            Random rand = new Random();

            if (amount == 1)
            {
                n = rand.Next(numbOfLetters);
                hiddenWord = DiscoverLetters(hiddenWord, word, word[n].ToString());
            }
            else if (amount > 1) // I don't know how to check if the letter wasn't draw earlier ;/ so sometimes it shows only 1 or 2 various letters
            {
                int i = 0;

                do
                {
                    n = rand.Next(numbOfLetters);
                    hiddenWord = DiscoverLetters(hiddenWord, word, word[n].ToString());
                    i++;
                } while(i < amount);
            }

            return hiddenWord;
        }

        #endregion

        #region Methods private

        // add places where the letter is to the list, when the letter isn't on the place, -1 is added to the list
        private List<int> AddPlacesOfLetterOccuranceToList(string wordToGuess, string letter)
        {
            List<int> placesOfLetter = new List<int>();

            
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

            return placesOfLetter;
        }

        #endregion
    }
}
