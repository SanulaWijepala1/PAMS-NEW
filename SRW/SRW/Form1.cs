using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SRW
{
    public partial class Form1 : Form
    {
        private const string validUsername = "admin";
        private const string validPassword = "123";
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50; // Set the timer interval to 50 milliseconds
            timer1.Tick += timer1_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            }

        private void button1_Click(object sender, EventArgs e)
        {
           

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            

            String password = textBox1.Text;
            String username = textBox2.Text;
            

            if (username == validUsername && password == validPassword) { MessageBox.Show("Login Successful, Welcome"+ username);
                
                textBox1.ResetText();
               
                textBox2.ResetText();
                

            }
                else{
                MessageBox.Show("Sorry, Incorrect UserName or Password");
                textBox1.ResetText();
                textBox2.ResetText();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 1;
                guna2HtmlLabel2.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
