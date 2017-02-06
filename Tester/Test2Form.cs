using System;
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
    public partial class Test2Form : Form
    {
        public Test1Form test1;
        String login;
        Stopwatch mainStopwatch;
        long testsTime;
        int lvl;
        public int points;

        public Test2Form(Test1Form test1, String login, long testsTime)
        {
            InitializeComponent();
            this.test1 = test1;
            this.login = login;
            this.testsTime = testsTime;
            test1.Visible = false;
            this.mainStopwatch = new Stopwatch();
            this.lvl = 0;
            this.points = 0;
            setLevel();
        }

        private void Test2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.test1.Close();
        }

        private void setLevel()
        {
            this.answerTextBox.Text = null;

            switch (this.lvl)
            {
                case 0:
                    headlineLabel.Text = "Przykład";
                    pictureBox.Image = Image.FromFile(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\29.png");
                    break;
                case 1:
                    headlineLabel.Text = "Zadanie 1/3";
                    pictureBox.Image = Image.FromFile(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\73.png");
                    this.mainStopwatch.Start();
                    this.timeTimer.Enabled = true;
                    break;
                case 2:
                    headlineLabel.Text = "Zadanie 2/3";
                    pictureBox.Image = Image.FromFile(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\45.png");
                    break;
                case 3:
                    headlineLabel.Text = "Zadanie 3/3";
                    pictureBox.Image = Image.FromFile(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\7.png");
                    break;
                default:
                    Console.WriteLine("Level not set.");
                    break;
            }
            this.okButton.Enabled = true;
        }

        private void addPoints()
        {
            if (this.lvl == 1 && this.answerTextBox.Text.Trim() == "73")
                this.points++;
            if (this.lvl == 2 && this.answerTextBox.Text.Trim() == "45")
                this.points++;
            if (this.lvl == 3 && this.answerTextBox.Text.Trim() == "7")
                this.points++;
            Console.WriteLine("Test: 2 Level: " + this.lvl + " Points: " + points);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            okButton.Enabled = false;
            addPoints();

            if (this.lvl >= 3)
            {
                this.mainStopwatch.Stop();
                this.timeTimer.Enabled = false;
                Test3Form test3 = new Test3Form(this, this.login, mainStopwatch.ElapsedMilliseconds + testsTime);
                test3.Visible = true;
                return;
            }

            this.lvl++;
            setLevel();
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
    }
}
