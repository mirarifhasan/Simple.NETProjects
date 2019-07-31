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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizPage quizForm = new QuizPage("easy");
            quizForm.Show();
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizPage quizForm = new QuizPage("medium");
            quizForm.Show();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizPage quizForm = new QuizPage("hard");
            quizForm.Show();
        }
    }
}
