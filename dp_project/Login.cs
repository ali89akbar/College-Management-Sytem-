using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_project
{
    public partial class Login : Form
    {
       public string valid;
        public Login()
        {
            InitializeComponent();
            
        }

        private void std_teach_Load(object sender, EventArgs e)
        {

        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Username or Pasword");
            }
            else
            {
                string desiredRole = radioButton1.Checked ? "Admin" : radioButton2.Checked ? "Student" : "";
                if (Singleton.Instance.Login(textBox1.Text, textBox2.Text,desiredRole))
                {
                    LoginInfo loginInfo = new LoginInfo();
                    loginInfo.t_s(textBox1.Text, textBox2.Text, radioButton1.Checked, radioButton2.Checked);
                    // this.Hide();
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
