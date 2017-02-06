using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            Test1Form test1Form = new Test1Form(this, loginTextBox.Text);
            test1Form.Visible = true;
        }
    }
}
