using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Solution
{
    public partial class Forgot : Form
    {

        private string phoneNumber {  get; set; }
        private string otp { get; set; }
        public Forgot()
        {
            InitializeComponent();
        }

        private void fbox1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            fbox3.Visible = false;
            submit.Visible = false;
            register.Visible = false;
        }



        private void search_Click(object sender, EventArgs e)
        {
            string query = $"SELECT Name FROM users WHERE [phone_number] = '{fbox2.Text}'";
            SqlDataReader reader = databse.ExecuteReader(query);
            if (reader.Read())
            {
                string phone = reader["Name"].ToString();
                this.phoneNumber = fbox2.Text;
                label2.Text = phone;
                textBox1.Visible = false;
                fbox3.Visible = true;
                submit.Visible = true;
                search.Visible = false;
                fbox2.Visible = false;
                register.Visible = false;
            }
            else
            {
                MessageBox.Show("Username not found.");
            }
        }




        private void submit_click(object sender, EventArgs e)
        {
            this.otp = fbox3.Text;
            submit.Visible = false;
            register.Visible = true;
            textBox1.Visible = true;
            fbox2.Visible = true;
            fbox3.Visible = true;

        }





        private void regester_Click(object sender, EventArgs e)
        {
            if (fbox2.Text == fbox3.Text)
            {
                MessageBox.Show("Both password not matched.");
                return;
            }
            else
            {
                if (otp_and_code.verify_code(otp, phoneNumber))
                {

                    string query = $"UPDATE users SET password = '{fbox2.Text}' WHERE phone_number = '{phoneNumber}'";


                    databse.ExecuteNonQuery(query);
                    MessageBox.Show("Password updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the correct OTP.");
                }
            }
            
        }
    }
}
