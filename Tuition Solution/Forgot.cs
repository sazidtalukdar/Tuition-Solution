using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuition_Solution
{
    public partial class Forgot : Form
    {
        private otp_and_code otpTool = new otp_and_code();
        private string phoneNumber { get; set; }

        public Forgot()
        {
            InitializeComponent();
        }

        private void Forgot_Load_1(object sender, EventArgs e)
        {
            fbox1.Visible = false;
            fbox3.Visible = false;
            regester.Visible = false;

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (fbox2.Text == null)
            {
                MessageBox.Show("Please enter your phone number.");
                return;
            }
            else
            {

                string query = $"SELECT Name FROM users WHERE [phone_number] = '{fbox2.Text}'";
                SqlDataReader reader = databse.ExecuteReader(query);


                if (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    phoneNumber = fbox2.Text;

                    label1.Text = $"Welcome, {name}";
                    fbox1.Visible = true;
                    fbox2.Visible = true;
                    fbox2.Text = "";
                    fbox3.Visible = true;
                    search.Visible = false;
                    regester.Visible = true;

                    string code = otpTool.get_code();
                    string sms = $"Your otp is {code}.  Do not share your opt with any one . Thank you";
                    otpTool.set_code(code);
                    otpTool.SendSms(phoneNumber,sms);
                }
                else
                {
                    MessageBox.Show("Phone number not found.");
                }

                reader.Close();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (fbox1.Text == null && fbox2.Text == null && fbox3.Text == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (fbox2.Text != fbox3.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!otpTool.verify_code(fbox1.Text))
            {
                MessageBox.Show("Incorrect OTP.");
                return;
            }
            else
            {

                string query = $"UPDATE users SET password = '{fbox2.Text}' WHERE phone_number = '{phoneNumber}'";
                databse.ExecuteNonQuery(query);

                MessageBox.Show("Password updated successfully.");
               
            }

        }
    }
}

