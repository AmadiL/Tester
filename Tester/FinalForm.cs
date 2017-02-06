using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tester
{
    public partial class FinalForm : Form
    {
        Test3Form test3;
        String login;
        long testsTime;
        public int points;

        public FinalForm(Test3Form test3, String login, long testsTime)
        {
            InitializeComponent();
            this.test3 = test3;
            this.login = login;
            this.testsTime = testsTime;

            points = test3.points + test3.test2.points + test3.test2.test1.points;
            pointsLabel.Text = points.ToString();

            loginLabel.Text = login;
            TimeSpan t = TimeSpan.FromMilliseconds(testsTime);
            this.timeLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds,
                                    t.Milliseconds);
            pointsChart.Series.Clear();
            Series series = pointsChart.Series.Add("Test 1");
            series.Points.Add(test3.test2.test1.points);
            series = pointsChart.Series.Add("Test 2");
            series.Points.Add(test3.test2.points);
            series = pointsChart.Series.Add("Test 3");
            series.Points.Add(test3.points);
        }

        private void FinalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            test3.Close();
        }
    }
}
