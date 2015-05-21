using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace appShuffleGame
{
    public partial class frmShuffle : Form
    {
        ArrayList numbers = new ArrayList();
        int moves;
        
        public frmShuffle()
        {
            InitializeComponent();

            for (int i = 1; i < 16; i++)
            {
                numbers.Add(i);
            }
            Shuffle();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // 2, 5
            if (button1.Text != "")
            {
                if (button2.Text == "")
                {
                    button2.Text = button1.Text;
                    button1.Text = "";
                    ItsWinner();
                }
                else if (button5.Text == "")
                {
                    button5.Text = button1.Text;
                    button1.Text = "";
                    ItsWinner();
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 , 6, 3
            if (button2.Text != "")
            {
                if (button1.Text == "")
                {
                    button1.Text = button2.Text;
                    button2.Text = "";
                    ItsWinner();
                }
                else if (button6.Text == "")
                {
                    button6.Text = button2.Text;
                    button2.Text = "";
                    ItsWinner();
                }
                else if (button3.Text == "")
                {
                    button3.Text = button2.Text;
                    button2.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2 7 4
            if (button3.Text != "")
            {
                if (button2.Text == "")
                {
                    button2.Text = button3.Text;
                    button3.Text = "";
                    ItsWinner();
                }
                else if (button7.Text == "")
                {
                    button7.Text = button3.Text;
                    button3.Text = "";
                    ItsWinner();
                }
                else if (button4.Text == "")
                {
                    button4.Text = button3.Text;
                    button3.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3 8
            if (button4.Text != "")
            {
                if (button3.Text == "")
                {
                    button3.Text = button4.Text;
                    button4.Text = "";
                    ItsWinner();
                }
                else if (button8.Text == "")
                {
                    button8.Text = button4.Text;
                    button4.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //1 6 9
            if (button5.Text != "")
            {
                if (button1.Text == "")
                {
                    button1.Text = button5.Text;
                    button5.Text = "";
                    ItsWinner();
                }
                else if (button6.Text == "")
                {
                    button6.Text = button5.Text;
                    button5.Text = "";
                    ItsWinner();
                }
                else if (button9.Text == "")
                {
                    button9.Text = button5.Text;
                    button5.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //2 7 5 10
            if (button6.Text != "")
            {
                if (button2.Text == "")
                {
                    button2.Text = button6.Text;
                    button6.Text = "";
                    ItsWinner();
                }
                else if (button5.Text == "")
                {
                    button5.Text = button6.Text;
                    button6.Text = "";
                    ItsWinner();
                }
                else if (button7.Text == "")
                {
                    button7.Text = button6.Text;
                    button6.Text = "";
                    ItsWinner();
                }
                else if (button10.Text == "")
                {
                    button10.Text = button6.Text;
                    button6.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 3 6 8 11
            if (button7.Text != "")
            {
                if (button3.Text == "")
                {
                    button3.Text = button7.Text;
                    button7.Text = "";
                    ItsWinner();
                }
                else if (button6.Text == "")
                {
                    button6.Text = button7.Text;
                    button7.Text = "";
                    ItsWinner();
                }
                else if (button8.Text == "")
                {
                    button8.Text = button7.Text;
                    button7.Text = "";
                    ItsWinner();
                }
                else if (button11.Text == "")
                {
                    button11.Text = button7.Text;
                    button7.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //4 7 12
            if (button8.Text != "")
            {
                if (button4.Text == "")
                {
                    button4.Text = button8.Text;
                    button8.Text = "";
                    ItsWinner();
                }
                else if (button7.Text == "")
                {
                    button7.Text = button8.Text;
                    button8.Text = "";
                    ItsWinner();
                }
                else if (button12.Text == "")
                {
                    button12.Text = button8.Text;
                    button8.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //5 10 13
            if (button9.Text != "")
            {
                if (button5.Text == "")
                {
                    button5.Text = button9.Text;
                    button9.Text = "";
                    ItsWinner();
                }
                else if (button10.Text == "")
                {
                    button10.Text = button9.Text;
                    button9.Text = "";
                    ItsWinner();
                }
                else if (button13.Text == "")
                {
                    button13.Text = button9.Text;
                    button9.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //6 9 11 14
            if (button10.Text != "")
            {
                if (button6.Text == "")
                {
                    button6.Text = button10.Text;
                    button10.Text = "";
                    ItsWinner();
                }
                else if (button9.Text == "")
                {
                    button9.Text = button10.Text;
                    button10.Text = "";
                    ItsWinner();
                }
                else if (button11.Text == "")
                {
                    button11.Text = button10.Text;
                    button10.Text = "";
                    ItsWinner();
                }
                else if (button14.Text == "")
                {
                    button14.Text = button10.Text;
                    button10.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //7 10 12 15
            if (button11.Text != "")
            {
                if (button7.Text == "")
                {
                    button7.Text = button11.Text;
                    button11.Text = "";
                    ItsWinner();
                }
                else if (button10.Text == "")
                {
                    button10.Text = button11.Text;
                    button11.Text = "";
                    ItsWinner();
                }
                else if (button12.Text == "")
                {
                    button12.Text = button11.Text;
                    button11.Text = "";
                    ItsWinner();
                }
                else if (button15.Text == "")
                {
                    button15.Text = button11.Text;
                    button11.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //8 11 16
            if (button12.Text != "")
            {
                if (button11.Text == "")
                {
                    button11.Text = button12.Text;
                    button12.Text = "";
                    ItsWinner();
                }
                else if (button8.Text == "")
                {
                    button8.Text = button12.Text;
                    button12.Text = "";
                    ItsWinner();
                }
                else if (button16.Text == "")
                {
                    button16.Text = button12.Text;
                    button12.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //9 14
            if (button13.Text != "")
            {
                if (button9.Text == "")
                {
                    button9.Text = button13.Text;
                    button13.Text = "";
                    ItsWinner();
                }
                else if (button14.Text == "")
                {
                    button14.Text = button13.Text;
                    button13.Text = "";
                    ItsWinner();
                }                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //13 10 15
            if (button14.Text != "")
            {
                if (button10.Text == "")
                {
                    button10.Text = button14.Text;
                    button14.Text = "";
                    ItsWinner();
                }
                else if (button13.Text == "")
                {
                    button13.Text = button14.Text;
                    button14.Text = "";
                    ItsWinner();
                }
                else if (button15.Text == "")
                {
                    button15.Text = button14.Text;
                    button14.Text = "";
                    ItsWinner();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //14 11 16
            //Change(button15, button14);
            if (button15.Text != "")
            {
                if (button14.Text == "")
                {
                    button14.Text = button15.Text;
                    button15.Text = "";
                    ItsWinner();
                }
                else if (button11.Text == "")
                {
                    button11.Text = button15.Text;
                    button15.Text = "";
                    ItsWinner();
                }
                else if (button16.Text == "")
                {
                    button16.Text = button15.Text;
                    button15.Text = "";
                    ItsWinner();
                }
            }            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //12 15
            if (button16.Text != "")
            {
                if (button12.Text == "")
                {
                    button12.Text = button16.Text;
                    button16.Text = "";
                    ItsWinner();
                }
                else if (button15.Text == "")
                {
                    button15.Text = button16.Text;
                    button16.Text = "";
                    ItsWinner();
                }
            }
        }

        private void ItsWinner()
        {
            moves++;

            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("You win with " + moves + " moves!");
            }
        }

        private void Shuffle()
        {
            moves = 0;

            ArrayList sortedList = new ArrayList();
            Random random = new Random();

            while (numbers.Count > 0)
            {
                int p = random.Next(numbers.Count);
                sortedList.Add(numbers[p]);
                numbers.RemoveAt(p);
            }

            numbers = sortedList;

            button1.Text = numbers[0].ToString();
            button2.Text = numbers[1].ToString();
            button3.Text = numbers[2].ToString();
            button4.Text = numbers[3].ToString();
            button5.Text = numbers[4].ToString();
            button6.Text = numbers[5].ToString();
            button7.Text = numbers[6].ToString();
            button8.Text = numbers[7].ToString();
            button9.Text = numbers[8].ToString();
            button10.Text = numbers[9].ToString();
            button11.Text = numbers[10].ToString();
            button12.Text = numbers[11].ToString();
            button13.Text = numbers[12].ToString();
            button14.Text = numbers[13].ToString();
            button15.Text = numbers[14].ToString();
            button16.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShuffle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
