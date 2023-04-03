using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tik_tack_to
{
    public partial class Form1 : Form
    {
        static int  click1 = 0;
        static int turn = 0;
        static int player1 = 0;
        static int player2 = 0;
        public void display()
        {
            if (turn % 2 != 0)
            {
                displayturn.Text = "Player 1";
            }
            else
            {
                displayturn.Text = "Player 2";
            }
        }

        public void checkit()
        {
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                //cross
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                //cross
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                //1st row
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }

            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                //row2
                //2st row
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    if (button2.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                //row3

                //3st row
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                //colum2
                //2st colum
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    if (button4.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                //colum3
                //3st colum
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button7.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");


                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }

                }
            }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                //1st colum
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        player1++;
                        player1score.Text = player1.ToString();
                        MessageBox.Show("Player 1 Wins!");
                       
                       
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    
                }
                
                
                
                
               
                
            }
        }
        void cleargame()
        {
            player1score.Text = "";
            player2score.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
           
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                turn++;
                click1++;
           
            display();
            checkit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                
                }
                else
                {
                    button1.Text = "O";
                }
                turn++;
                click1++;
            
            display();
            checkit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //button2.Text = "X";
            //if (click1 == 0)
            //{
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                turn++;
                click1++;
            //}
            //else
            //{
            //    button2.Text = button1.Text;
            //}
            display();
            checkit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                turn++;
                click1++;
          
            display();
            checkit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                turn++;
                click1++;
            
           
            display();
            checkit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                turn++;
                click1++;
           
            display();
            checkit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
           
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                turn++;
                click1++;
            
           
            display();
            checkit();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                turn++;
                click1++;
            
            
            display();
            checkit();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                turn++;
                click1++;
           
            display();
            checkit();
        }

        private void player1score_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            cleargame();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            turn = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;

        }
    }
}
