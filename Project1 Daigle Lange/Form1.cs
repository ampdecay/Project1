using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WordSets;

namespace Project1_Daigle_Lange
{
    public partial class Form1 : Form
    {
        
        private int counter;

        //false is stoped state, true is running state 
        //used for start/stop button to control timer
        private bool startStop = false;
        //has the go button been pressed once?
        private bool goneOnce = false;
        
        private  Random rand = new Random();
        //used to select random letters
        private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private WordSets.WordSets word = new WordSets.WordSets("Words5.txt");

        public Form1()
        {
            word.SetLength(5);
            InitializeComponent();
            fill_list(word);
            intializeButtons();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            int selector;
            selector = (int)numericUpDown_wordLength.Value;
            Control c;
            if (counter < selector)//increasing case
            {
                c = groupBox_buttonGroup.Controls[selector - 1];
                c.Visible = true;
                ++counter;
            }
            if (selector < counter) //decreasing case
            {
                c = groupBox_buttonGroup.Controls[selector];
                c.Visible = false;
                --counter;
            }
        }

        //accepts a WordSet class as input and fills local list from it
        private void fill_list(WordSets.WordSets word)
        {
            wordListBox.Items.Clear();
            List<string> currentList = word.GetList();
            wordListBox.Items.AddRange(currentList.ToArray());
        }

        //intialize which buttons to display
        private void intializeButtons ()
        {
            Control tempControl;
            
            counter = (int)numericUpDown_wordLength.Value;
            for (int i = 0; i < counter; ++i)
            {
                tempControl = groupBox_buttonGroup.Controls[i];
                tempControl.Visible = true;
                tempControl.Text = "";
                tempControl.BackColor = Color.Beige;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Control tempcontrol;
            for(int i = 0; i < 5; ++i)
            {
                tempcontrol = groupBox_buttonGroup.Controls[i];
                if (tempcontrol.Enabled)
                {
                    int randomNumber = rand.Next(0, 26);
                    tempcontrol.Text = alphabet[randomNumber].ToString();
                }  
            }
        }

        private void button_startStop_Click(object sender, EventArgs e)
        {
           
            if (!startStop)
            {
                if (!goneOnce)
                {
                    enableBoxes();
                    fillBoxes();
                }
                timer1.Start();
                button_startStop.BackColor = Color.Red;
                button_startStop.Text = "Stop!";
                startStop = true;
                goneOnce = true;
            }
               
            else
            {
                timer1.Stop();
                button_startStop.BackColor = Color.Green;
                button_startStop.Text = "Go!";
                startStop = false;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            startStop = false;
            button_startStop.BackColor = Color.Green;
            button_startStop.Text = "Go!";
            intializeButtons();
            timer1.Stop();
            disableBoxes();
            word = new WordSets.WordSets("Words5.txt");
            word.SetLength(5);
            fill_list(word);
            goneOnce = false;
        }

        private void fillBoxes()
        {
            Control tempcontrol;
            for (int i = 0; i < 5; ++i)
            {
                tempcontrol = groupBox_buttonGroup.Controls[i];
                if (tempcontrol.Enabled)
                {
                    int randomNumber = rand.Next(0, 26);
                    tempcontrol.Text = alphabet[randomNumber].ToString();
                }

            }

        }

        private void enableBoxes()
        {
            Control tempcontrol;
            for (int i = 0; i < 5; ++i)
            {
                tempcontrol = groupBox_buttonGroup.Controls[i];
                tempcontrol.Enabled = true;
            }
        }

        private void disableBoxes()
        {
            Control tempcontrol;
            for (int i = 0; i < 5; ++i)
            {
                tempcontrol = groupBox_buttonGroup.Controls[i];
                tempcontrol.Enabled = false;
            }

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            
            char[] charToAdd = button_1.Text.ToCharArray();
            
            word.SetLetter(0, charToAdd[0]);
            List<string> checkList = word.GetList();
            //if insertion fails set color to red
            if (checkList.Count == 0)
            {
                button_1.BackColor = Color.Red;
                word.SetLetter(0, ' ');
            }
            else if(checkList.Count != 0)
            //repopulate list and disable button
            {
                fill_list(word);
                button_1.Enabled = false;
                button_1.BackColor = Color.Green;
            }
            if (checkList.Count == 1) 
            {
                autoComplete();
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
           
            char[] charToAdd = button_2.Text.ToCharArray();
            
            word.SetLetter(1, charToAdd[0]);
            List<string> checkList = word.GetList();
            //if insertion fails set color to red
            if (checkList.Count == 0)
            {
                button_2.BackColor = Color.Red;
                word.SetLetter(1, ' ');
            }
            else if(checkList.Count != 0)
            //repopulate list and disable button
            {
                fill_list(word);
                button_2.Enabled = false;
                button_2.BackColor = Color.Green;
                if (charToAdd[0] == 'Q')
                {
                    word.SetLetter(2, 'U');
                    fill_list(word);
                    button_3.Enabled = false;
                    button_3.BackColor = Color.Green;
                    button_3.Text = "U";
                }
            }
            if (checkList.Count == 1)
            {
                autoComplete();
            }
           
        }

        private void button_3_Click(object sender, EventArgs e)
        {
           
            char[] charToAdd = button_3.Text.ToCharArray();
            
            word.SetLetter(2, charToAdd[0]);
            List<string> checkList = word.GetList();
            //if insertion fails set color to red
            if (checkList.Count == 0)
            {
                button_3.BackColor = Color.Red;
                word.SetLetter(2, ' ');
            }
            else if(checkList.Count != 0)
            //repopulate list and disable button
            {
                fill_list(word);
                button_3.Enabled = false;
                button_3.BackColor = Color.Green;
            }
            if (checkList.Count == 1)
            {
                autoComplete();
            } 
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            
            char[] charToAdd = button_4.Text.ToCharArray();
            
            word.SetLetter(3, charToAdd[0]);
            List<string> checkList = word.GetList();
            //if insertion fails set color to red
            if (checkList.Count == 0)
            {
                button_4.BackColor = Color.Red;
                word.SetLetter(3, ' ');
            }
            else if (checkList.Count != 0)
            //repopulate list and disable button
            {
                fill_list(word);
                button_4.Enabled = false;
                button_4.BackColor = Color.Green;
            }
            if (checkList.Count == 1)
            {
                autoComplete();
            }
            
        }

        private void button_5_Click(object sender, EventArgs e)
        {
           
            char[] charToAdd = button_5.Text.ToCharArray();
            
            word.SetLetter(4, charToAdd[0]);
            List<string> checkList = word.GetList();
            //if insertion fails set color to red and discard letter
            if (checkList.Count == 0)
            {
                button_5.BackColor = Color.Red;
                word.SetLetter(4, ' ');
            }
            else if(checkList.Count != 0)
            //repopulate list and disable button
            {
                fill_list(word);
                button_5.Enabled = false;
                button_5.BackColor = Color.Green;
            }
            if (checkList.Count == 1)
            {
                autoComplete();
            }
            
        }

        /*when only one word is left in the
         * list this method fills the rest
         * of the buttons in that have yet to
         * be filled in
         */
        private void autoComplete() 
        {
            Control tempControl;
            List<string> wordToFill = word.GetList();
            string[] letters = wordToFill.ToArray();
            string letter_chars = letters[0];
            char[] insertLetters = letter_chars.ToCharArray();

            for (int i = 0; i < 5; ++i)
            {
                tempControl = groupBox_buttonGroup.Controls[i];
                tempControl.Text = insertLetters[i].ToString();
                tempControl.BackColor = Color.Green;
                tempControl.Enabled = false;
            }
        
        }

       
    }
}
 