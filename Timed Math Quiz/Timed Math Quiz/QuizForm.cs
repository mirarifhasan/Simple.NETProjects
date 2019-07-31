using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timed_Math_Quiz
{
    public partial class QuizPage : Form
    {
        int timeLeft = 30;
        string level;

        public QuizPage(String level)
        {
            InitializeComponent();

            this.level = level;
            timeLeftLabel.Text = "Time Left: " + timeLeft + " Sec";
            submitButton.Text = "START";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(submitButton.Text == "START" || submitButton.Text == "Try Again!" || submitButton.Text == "Play Again!")
            {
                generateNumber();
                submitButton.Text = "SUBMIT";
                timer2.Start();
            }
            else if(submitButton.Text == "SUBMIT")
            {
                timer2.Stop();

                if (CheckTheAnswer())
                {
                    submitButton.Text = "Play Again!";
                    MessageBox.Show("You win the game.", "Congratulations!");
                }
                else
                {
                    submitButton.Text = "Try Again!";
                    MessageBox.Show("You lose the game.", "Oh!");
                }

            }
        }

        private void generateNumber()
        {
            Random random = new Random();

            int upper = 10, lower = 5; //This variables is the range of values.

            if (level.Equals("easy"))
            {
                upper = 15;
                lower = 3;
            }
            else if (level.Equals("medium"))
            {
                upper = 25;
                lower = 9;
            }
            else
            {
                upper = 35;
                lower = 15;
            }

            plusLeft.Text = random.Next(lower,upper).ToString();
            plusRight.Text = random.Next(lower, upper).ToString();

            minLeft.Text = random.Next(lower, upper).ToString();
            minRight.Text = random.Next(lower, upper).ToString();

            mulLeft.Text = random.Next(lower, upper/2).ToString();
            mulRight.Text = random.Next(lower, upper/2).ToString();

            int divRandAns = random.Next(lower, upper);
            int divisor = random.Next(lower, upper);
            int divident = divRandAns * divisor;

            divLeft.Text = divident.ToString();
            divRight.Text = divisor.ToString();
        }

        private bool CheckTheAnswer()
        {
            bool b = true;

            if(Convert.ToInt32(plusLeft.Text) + Convert.ToInt32(plusRight.Text) != plusRes.Value)
                b = false;
            else if (Convert.ToInt32(minLeft.Text) - Convert.ToInt32(minRight.Text) != minRes.Value)
                b = false;
            else if (Convert.ToInt32(mulLeft.Text) * Convert.ToInt32(mulRight.Text) != mulRes.Value)
                b = false;
            else if (Convert.ToInt32(divLeft.Text) / Convert.ToInt32(divRight.Text) != divRes.Value)
                b = false;
            
            return b;
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timeLeft < 10)
            {
                timeLeftLabel.BackColor = Color.Red;
            }

            if (timeLeft > 0)
            {
                timeLeft--;
                timeLeftLabel.Text = "Time Left: " + timeLeft + " Sec";
            }
            else
            {
                timer2.Stop();
                timeLeftLabel.Text = "Time's up!";
                submitButton.Text = "Try Again!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homeForm = new HomePage();
            homeForm.Show();
        }
    }
}
