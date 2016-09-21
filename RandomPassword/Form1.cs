using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Winforms Initialization                      
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            #region Variables
            //Random rand = new Random();                           //Random
            int lenght = (int)numericUpDown.Value;                  //Lenght of the password
            int nbPassword = (int)numericUpDown_nbPass.Value;       //Number of password
            List<char> charList = new List<char>();                 //List of all the available char for the random
            int ListCount = 0;                                      //Number of element in the list
            string current = String.Empty;                          //Current string for the password generation
            #endregion
                                 
            #region Generating CharList
            if (checkBox_number.Checked)                            //Check if the Checkbox is checked, if so add or remove the affected char
            {
                for (int i = 0; i < 10; i++)
                {
                    charList.Add(i.ToString()[0]);
                }
            }
            if (checkBox_lowercase.Checked)
            {
                for (int i = 0; i < 26; i++)
                {
                    charList.Add(Convert.ToChar(i + 97));
                }
            }
            if (checkbox_uppercase.Checked)
            {
                for (int i = 0; i < 26; i++)
                {
                    charList.Add(Convert.ToChar(i + 65));
                }
            }
            if (checkBox_special.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    charList.Add(Convert.ToChar(i + 33));
                }
                for (int i = 0; i < 7; i++)
                {
                    charList.Add(Convert.ToChar(i + 58));
                }
                for (int i = 0; i < 5; i++)
                {
                    charList.Add(Convert.ToChar(i + 91));
                }
                for (int i = 0; i < 4; i++)
                {
                    charList.Add(Convert.ToChar(i + 123));
                }
            }
            if (checkBox_noSimilar.Checked)
            {
                for (int i = 0; i < charList.Count; i++)
                {
                    if (charList[i] == '0' || charList[i] == 'O' || charList[i] == 'I' || charList[i] == '1' || charList[i] == 'l')
                    {
                        charList.RemoveAt(i);
                    }
                }
            }
            charList.Shuffle();                                         //Shuffle the list
            ListCount = charList.Count;                                 //Update of the list count
            #endregion

            #region Generation
            //Generation
            richTextBox1.Text = String.Empty;                           //Cllear the TextBox
            int rand;
            //Prevent out of range if all the checkbox are unchecked or if the NoSimilar is the only one checked
            if ((!checkBox_lowercase.Checked && !checkBox_noSimilar.Checked && !checkbox_uppercase.Checked && !checkBox_number.Checked && !checkBox_special.Checked)
                || (!checkBox_lowercase.Checked && checkBox_noSimilar.Checked && !checkbox_uppercase.Checked && !checkBox_number.Checked && !checkBox_special.Checked))
            {
                richTextBox1.Text = "Paramètres incorrects.";
                return;
            }
            for (int i = 0; i < nbPassword; i++)                        
            {
                current = String.Empty;
                for (int j = 0; j < lenght; j++)
                {
                    rand = ThreadSafeRandom.ThisThreadsRandom.Next(ListCount);
                    current += charList[rand];
                }
                richTextBox1.Text += current + "\n";                    //Update the Textbox
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }
    }
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }
    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
  
}
