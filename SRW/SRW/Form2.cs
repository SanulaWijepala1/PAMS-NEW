using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace SRW
{
    public partial class Form2 : Form
    {
        String username;
        String newpassword;
        String confirmpassword;
        String name;
        String email;
        String Contno;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
        private void ResetTextBoxes()
        {
            guna2TextBox1.Text = string.Empty;
            guna2TextBox2.Text = string.Empty;
            guna2TextBox3.Text = string.Empty;
            guna2TextBox4.Text = string.Empty;
            guna2TextBox5.Text = string.Empty;
            guna2TextBox6.Text = string.Empty;

            // Optional: Set focus to the first text box after resetting
            guna2TextBox1.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*DateTime selectedDate = guna2DateTimePicker1.Value;
            MessageBox.Show("Selected Date of Birth: " + selectedDate.ToShortDateString());*/
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged_1(object sender, EventArgs e)

        {

            newpassword = guna2TextBox5.Text;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(guna2TextBox4.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                guna2TextBox4.Focus();
                return;
            }




            string contactPattern = @"^\d{10}$"; // This pattern ensures the string has exactly 10 digits
            if (!Regex.IsMatch(guna2TextBox6.Text, contactPattern))
            {
                MessageBox.Show("Contact number must be 10 digits long and contain only numbers.");
                guna2TextBox6.Focus();
                return;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) || guna2TextBox1.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                guna2TextBox1.Focus();
                return;
            }

            // Confirm Password Match
            if (guna2TextBox1.Text != guna2TextBox2.Text)
            {
                MessageBox.Show("Passwords do not match.");
                guna2TextBox2.Focus();
                return;
            }

            // If all validations pass
            MessageBox.Show("Validation successful!");
            // Proceed with further processing like saving data or navigating to another form



            if (!guna2CheckBox1.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions to proceed.");
                return;

            }

            if (guna2TextBox5.Text == confirmpassword && name != null && email != null && Contno != null)
            {
                MessageBox.Show("Registration Successful");
                ResetTextBoxes();
            }
            else { MessageBox.Show("Please ensure all fields are filled and passwords match."); ResetTextBoxes(); }
        }


        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            username = guna2TextBox4.Text;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            name = guna2TextBox1.Text;

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            confirmpassword = guna2TextBox6.Text;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            email = guna2TextBox2.Text;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            Contno = guna2TextBox3.Text;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}

