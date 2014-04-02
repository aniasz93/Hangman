using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    class FilesOperations
    {
        #region Methods

        // open a file
        public void OpenFile(string fileName, RichTextBox tb)
        {
            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(fileName);
                tb.Text = objReader.ReadToEnd();
                objReader.Close();
            }
            else
            {
                MessageBox.Show("File " + fileName + " not found ");
            }
        }

        // write results to ranking files
        public void WriteToFile(string fileName, string playerName, string time, string category)
        {
            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamWriter objWriter = new System.IO.StreamWriter(fileName, true);

                objWriter.Write(time + " " + category + " " + playerName + "\n");
                objWriter.Close();
            }
            else
            {
                MessageBox.Show("File " + fileName + " not found ");
            }
        }

        #endregion
    }
}
