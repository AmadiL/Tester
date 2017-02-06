using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Test3Form : Form
    {
        public Test2Form test2;
        String login;
        Stopwatch mainStopwatch;
        Stopwatch exerciseStopwatch;
        Random randomGenerator;
        long testsTime;
        int lvl;
        public int points;
        const int MIN_X = 152;
        const int MAX_X = 702;
        const int MIN_Y = 76;
        const int MAX_Y = 479;
        int x;
        int y;
        int appearTime;
        long reactionTime;
        ArrayList reactionTimeList;

        public Test3Form(Test2Form test2, String login, long testsTime)
        {
            InitializeComponent();
            this.test2 = test2;
            this.login = login;
            this.testsTime = testsTime;
            test2.Visible = false;
            this.mainStopwatch = new Stopwatch();
            this.exerciseStopwatch = new Stopwatch();
            this.randomGenerator = new Random();
            this.actionButton.Location = new Point(400, 200);
            this.lvl = -1;
            this.actionButton.Text = "START";
            this.reactionTimeList = new ArrayList();
        }

        private void Test3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.test2.Close();
        }

        private void setLevel()
        {
            actionButton.Enabled = false;
            actionButton.Visible = false;

            switch (this.lvl)
            {
                case 0:
                    headlineLabel.Text = "Przykład";
                    actionButton.Text = "KLIKNIJ!";
                    this.appearTime = randomGenerator.Next(500, 4000);
                    this.actionButton.Location = new Point(randomGenerator.Next(MIN_X, MAX_X),
                        randomGenerator.Next(MIN_Y, MAX_Y));
                    this.exerciseStopwatch.Restart();
                    this.exerciseTimer.Enabled = true;
                    break;
                case 1:
                    headlineLabel.Text = "Zadanie 1/3";
                    this.mainStopwatch.Start();
                    this.timeTimer.Enabled = true;

                    this.appearTime = randomGenerator.Next(500, 4000);
                    this.actionButton.Location = new Point(randomGenerator.Next(MIN_X, MAX_X),
                        randomGenerator.Next(MIN_Y, MAX_Y));
                    this.exerciseStopwatch.Restart();
                    this.exerciseTimer.Enabled = true;
                    break;
                case 2:
                    headlineLabel.Text = "Zadanie 2/3";
                    this.appearTime = randomGenerator.Next(500, 4000);
                    this.actionButton.Location = new Point(randomGenerator.Next(MIN_X, MAX_X),
                        randomGenerator.Next(MIN_Y, MAX_Y));
                    this.exerciseStopwatch.Restart();
                    this.exerciseTimer.Enabled = true;
                    break;
                case 3:
                    headlineLabel.Text = "Zadanie 3/3";
                    this.appearTime = randomGenerator.Next(500, 4000);
                    this.actionButton.Location = new Point(randomGenerator.Next(MIN_X, MAX_X),
                        randomGenerator.Next(MIN_Y, MIN_Y));
                    this.exerciseStopwatch.Restart();
                    this.exerciseTimer.Enabled = true;
                    break;
                default:
                    Console.WriteLine("Level not set.");
                    break;
            }
        }

        private void addPoints() {
            if (reactionTime <= 1500)
                points++;
            reactionTimeList.Add(reactionTime);
            Console.WriteLine("Test: 3 Level: " + this.lvl + " Points: " + points + " Reaction time: " + reactionTime);
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(mainStopwatch.ElapsedMilliseconds);
            this.timeLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds,
                                    t.Milliseconds);
        }

        private void exerciseTimer_Tick(object sender, EventArgs e)
        {
            if (exerciseStopwatch.ElapsedMilliseconds >= appearTime)
            {
                actionButton.Visible = true;
                actionButton.Enabled = true;
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (lvl > 0)
            {
                exerciseStopwatch.Stop();
                exerciseTimer.Enabled = false;
                actionButton.Visible = false;
                actionButton.Enabled = false;
                reactionTime = exerciseStopwatch.ElapsedMilliseconds - appearTime;
                addPoints();
            }

            if (lvl >= 3)
            {
                this.mainStopwatch.Stop();
                this.timeTimer.Enabled = false;
                FinalForm finalForm = new FinalForm(this, this.login, mainStopwatch.ElapsedMilliseconds + testsTime);
                finalForm.Visible = true;
                return;
            }

            lvl++;
            setLevel();
        }
    }
}
