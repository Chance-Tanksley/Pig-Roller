using Pig_Roller.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Pig_Roller
{
    public partial class Form1 : Form
    {
        protected int p1Score = 0;
        protected int p2Score = 0;
        protected int turnPoints = 0;
        protected int passCounter = 1;
        protected int p1winCounter = 0;
        protected int p2winCounter = 0;
        protected int gameCounter = 0;
        string path;

        public Form1()
        {
            InitializeComponent();
        }






        private void helpRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Pig Roller Rules: \nTwo Players will take turns rolling the pigs. \nClick the roll button to roll the pigs. After the points have been determined and added, you can either roll" +
                " again or pass your turn.\nFirst player to a hundred wins the game.");
        }

        private void pointSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pig Roller Point System:\nPig Out -- 0 Points\nSider -- 1 Point\nTrotter -- 5 Points\nDouble Trotter -- 20 Points\nRazorback -- 5 Points\n Double Razorback 20 Points\nSnouter -- 10 Points" +
                "\nDouble Snouter -- 40 Points\nLeaning Jowler -- 15 Points\n Double Leaning Jowler -- 60 Points\n Oinker -- Lose ALL Points, Pass Turn");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RollPigs();
            if (passCounter % 2 == 0)
            {
                p2ScoreBox.Text = turnPoints.ToString() + "\n";
            }
            else
            {
                p1ScoreBox.Text = turnPoints.ToString() + "\n";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passCounter % 2 == 0)
            {
                p2Score += turnPoints;
                turnPoints = 0;
                p2OverallScore.Text = p2Score.ToString();
                p2ScoreBox.Text = " ";

                if (p2Score >= 100)
                {
                    MessageBox.Show("Player 2 Wins with " + p2Score + " points!");
                    gameCounter++;
                    GamesPlayed.Text = gameCounter.ToString();
                    p2ScoreBox.BackColor = Color.FromArgb(52, 173, 83);
                    p1ScoreBox.BackColor = Color.FromArgb(255, 57, 57);
                    p2winCounter += 1;
                    p2GamesWon.Text = p2winCounter.ToString();
                }

            }
            else
            {
                p1Score += turnPoints;
                turnPoints = 0;
                p1OverallScore.Text = p1Score.ToString();
                p1ScoreBox.Text = " ";

                if (p1Score >= 100)
                {
                    MessageBox.Show("Player 1 Wins with " + p1Score + " points!");
                    gameCounter++;
                    GamesPlayed.Text = gameCounter.ToString();
                    p1ScoreBox.BackColor = Color.FromArgb(52, 173, 83);
                    p2ScoreBox.BackColor = Color.FromArgb(255, 57, 57);
                    p1winCounter+= 1;
                    p1GamesWon.Text = p1winCounter.ToString();
                }
            }
            passCounter++;
        }
        public void RollPigs()
        {

            Random rndPig = new Random();
            Random rnd = new Random();
            double num1 = rndPig.Next(1, 203);
            

            if (num1 == 1 || num1 == 2)
            {
                turnPoints += 60;
                PigsRolledBox.Text = "Double Leaning Jowler! 60 Points!";
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Double Leaning.jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
                

            }
            else if (num1 >= 3 && num1 <= 6)
            {
                turnPoints += 40;
                PigsRolledBox.Text = "Double Snouter! 40 Points!";
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Double Snouter.jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
                
            }
            else if (num1 >= 7 && num1 <= 9)
            {
                turnPoints += 25;
                PigsRolledBox.Text = "Snouter and Leaning Jowler! 25 Points!";
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Snouter and Leaning.jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
                

            }
            else if (num1 >= 10 && num1 <= 21)
            {
                turnPoints += 20;
                int num = rnd.Next(1, 5);
                switch (num)
                {
                    case 1:
                        PigsRolledBox.Text = "Double Trotter! 20 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Double Trotter.jpeg";
                        Image image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                    case 2:
                        PigsRolledBox.Text = "Double Razorback! 20 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Double Razorback.jpeg";
                        image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                    case 3:
                        PigsRolledBox.Text = "Trotter and Leaning Jowler! 20 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Trotter and Leaner.jpeg";
                        image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                    case 4:
                        PigsRolledBox.Text = "Razorback and Leaning Jowler! 20 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Razorback and Leaning (2).jpeg";
                        image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;

                }
                

            }
            else if (num1 >= 22 && num1 <= 28)
            {
                turnPoints += 15;
                int num = rnd.Next(1, 4);
                switch (num)
                {
                    case 1:
                        PigsRolledBox.Text = "Leaning Jowler! 15 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Razorback and Leaning.jpeg";
                        Image image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                    case 2:
                        PigsRolledBox.Text = "Snouter and Trotter! 15 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Snouter and Trotter.jpeg";
                        image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                    case 3:
                        PigsRolledBox.Text = "Snouter and Razorback! 15 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Snouter and Razorback.jpeg";
                        image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                }
                

            }
            else if (num1 >= 29 && num1 <= 44)
            {
                turnPoints += 10;
                int num = rnd.Next(1, 3);
                switch (num)
                {
                    case 1:
                        PigsRolledBox.Text = "Snouter! 10 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Snouter.jpeg";
                        Image image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                    case 2:
                        PigsRolledBox.Text = "Trotter and Razorback! 10 Points!";
                        path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Trotter and Razorback.jpeg";
                        image = Image.FromFile(path);
                        pictureBox2.Image = image;
                        break;
                }
                
            }
            else if (num1 >= 45 && num1 <= 120)
            {
                turnPoints += 5;
                PigsRolledBox.Text = "Trotter or Razorback! 5 Points!";
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Razorback.jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
            }
            else if (num1 >= 121 && num1 <= 165)
            {
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Sider.jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
                turnPoints += 1;
                PigsRolledBox.Text = "Sider! 1 Point!";
            }
            else if (num1 >= 166 && num1 <= 200)
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\New Project - Pig-Oinking-www.fesliyanstudios.com.mp3.wav");
                player.Play();
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\PigOut (2).jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
         
                if (passCounter % 2 == 0)
                {
                    p2ScoreBox.Text = " ";
                    turnPoints = 0;
                    PigsRolledBox.Text = "Pig Out! You lost this turn's accrued points!";
                    passCounter++;
                }
                else
                {
                    p1ScoreBox.Text = " ";
                    turnPoints = 0;
                    PigsRolledBox.Text = "Pig Out! You lost this turn's accrued points!";
                    passCounter++;
                }
                
            }
            else if (num1 == 201 || num1 == 202)
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\New Project - Pig-Squealing-B-www.fesliyanstudios.com.mp3.wav");
                player.Play();
                path = "C:\\Users\\chanc\\source\\repos\\Pig Roller\\Pig Roller\\Resources\\Oinker.jpeg";
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
                PigsRolledBox.Text = "Oinker! Your pigs touched... you lost ALL of your points!";
                turnPoints = 0;
                if (passCounter % 2 == 0)
                {
                    p2Score = 0;
                    passCounter++;
                    p2ScoreBox.Text = " ";
                    p2OverallScore.Text = p2Score.ToString();
                    p2ScoreBox.Text = " ";
                }
                else
                {
                    p1Score = 0;
                    passCounter++;
                    p2ScoreBox.Text = " ";
                    p1OverallScore.Text = p1Score.ToString();
                    p1ScoreBox.Text = " ";

                }
                
            }


        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            PigsRolledBox.Text = " ";

            p1OverallScore.Text = " ";
            p1ScoreBox.BackColor = Color.White;
            p1ScoreBox.Text = " ";
            p1Score = 0;

            p2OverallScore.Text = " ";
            p2ScoreBox.BackColor = Color.White;
            p2ScoreBox.Text = " ";
            p2Score = 0;

            turnPoints = 0;


        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            this.AutoSize = true; this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.AutoSize = true; this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        
    }
}
