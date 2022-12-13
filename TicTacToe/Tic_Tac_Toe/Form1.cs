using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn, false = O turn
        int turnCount = 0;
        static string player1, player2;
        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayerNames(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Tic Tac Toe game\n By Matt Tarpley", "Tic Tac Toe About");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            ++turnCount;

            CheckForWinner();

        }//end button_Click

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            //Horizontal Checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;

            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //Vertical Checks 
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //Diagonal Checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;



            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = player2;
                    numP2Wins.Text = (Int32.Parse(numP2Wins.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    numP1Wins.Text = (Int32.Parse(numP1Wins.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins!", "Yay!");
            }//end if  
            else if (turnCount == 9)
            {
                MessageBox.Show("Draw", "Bummer!");
                numDraws.Text = (Int32.Parse(numDraws.Text) + 1).ToString();
            }
       
        }//end CheckForWinner

        private void disableButtons()
        {
            foreach(Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }

            }// end foreach


        }//End disable buttons

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }

            }// end foreach

        }//end NewGame

        private void button_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//end if 
                
        }//end mouse enter

        private void button_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(b.Enabled)
                b.Text = "";
        }//end mouse leave

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numP2Wins.Text = "0";
            numP1Wins.Text = "0";
            numDraws.Text = "0";
        }//end resetWins

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();

            player1Label.Text = player1;
            player2Label.Text = player2;
        }//end formLoad
    }
}
