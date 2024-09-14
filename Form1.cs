using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "Teacher" && textBox_Password.Text == "Admin")
            {
                MessageBox.Show("Entering as Admin");
                this.Close();
                LMS lms = new LMS();
                lms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Inncorrect Login ID or Password, please try again.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
