using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Test1Form : Form
    {
        LoginForm loginForm;
        String login;
        SoundPlayer sound;
        Stopwatch mainStopwatch;
        int lvl;
        public int points;

        public Test1Form(LoginForm loginForm, String login)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.login = login;
            loginForm.Visible = false;
            this.mainStopwatch = new Stopwatch();
            this.lvl = 0;
            this.points = 0;
            setLevel();
        }

        private void Test1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.loginForm.Close();
        }

        private void playSoundButtonTest_Click(object sender, EventArgs e)
        {
            sound.Play();
            this.okButton.Enabled = true;
        }

        private void setLevel()
        {
            this.okButton.Enabled = false;
            this.answerComboBox.SelectedItem = null;

            switch (this.lvl)
            {
                case 0:
                    headlineLabel.Text = "Przykład";
                    this.sound = new SoundPlayer(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\kozy.wav");
                    break;
                case 1:
                    headlineLabel.Text = "Zadanie 1/3";
                    this.sound = new SoundPlayer(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\lew.wav");
                    this.mainStopwatch.Start();
                    this.timeTimer.Enabled = true;
                    break;
                case 2:
                    headlineLabel.Text = "Zadanie 2/3";
                    this.sound = new SoundPlayer(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\swierszcz.wav");
                    break;
                case 3:
                    headlineLabel.Text = "Zadanie 3/3";
                    this.sound = new SoundPlayer(@"C:\Users\alisieck\Documents\Visual Studio 2015\Projects\Tester\Tester\Multimedia\wilki.wav");
                    break;
                default:
                    Console.WriteLine("Level not set.");
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            okButton.Enabled = false;
            addPoints();

            if (this.lvl >= 3)
            {
                this.mainStopwatch.Stop();
                this.timeTimer.Enabled = false;
                Test2Form test2 = new Test2Form(this, this.login, mainStopwatch.ElapsedMilliseconds);
                test2.Visible = true;
                return;
            }

            this.lvl++;
            setLevel();
        }

        private void addPoints()
        {
            if (this.lvl == 1 && this.answerComboBox.SelectedIndex == 1)
                this.points++;
            if (this.lvl == 2 && this.answerComboBox.SelectedIndex == 3)
                this.points++;
            if (this.lvl == 3 && this.answerComboBox.SelectedIndex == 2)
                this.points++;
            Console.WriteLine("Test: 1 Level: " + this.lvl +" Points: " + points);
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
