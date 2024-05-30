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
using System.Drawing.Text;

namespace Israfil_Zekai_Yilmaz_68134_T5
{
    public partial class Form2 : Form
    {
        private bool isGamerunning=false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AliErkan();
           ClearGuess();
        }
        public void AliErkan()
        {
            if (!isGamerunning)
            {
                int min = Game.Min;
                int max = Game.Max;
                Random random = new Random();
                Game.GoalNum = random.Next(min, max);

                StartGame();
            }
            else
            {
                GuessNum();
            }
        }
        public string ClearGuess()
        {
          return  txtGuess.Text = "";
        }

        private void StartGame()
        {
            isGamerunning = true;
            timer1.Start();
            btnGuess.Text = "Guess!!";


        }
        private void GuessNum()
        {
            int guess;
            if (int.TryParse(txtGuess.Text, out guess))
            {
                if (guess > Game.GoalNum)
                {
                    label2.Text = "Guess lower";
                    
                }
                else if (guess< Game.GoalNum)
                {
                    label2.Text = "Guess higher";
                    
                }
                else
                {
                    MessageBox.Show("You Won");
                    timer1.Stop();
                }
            }

        }

        private void Timer()
        {
            label3.Text = $"{Game.Timer}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.Timer--;
            Timer();

            if (Game.Timer <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You Lost. Try Again");
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
