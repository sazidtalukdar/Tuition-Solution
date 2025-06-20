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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }



        private void singup_Click(object sender, EventArgs e)
        {
            if (phonebox.Text == "" || nmaebox.Text == "" || usernamebox.Text == "" || passbox.Text == "" ||gender_check()=="" || role_check()=="" )
            {
                MessageBox.Show("Please fill in all fields.");

            }
            else
            {
                if (valid_user(usernamebox.Text))
                {
                    if (passbox.Text != confirmpassbox.Text)
                    {
                        MessageBox.Show("Both Password Aren't Match");
                    }
                    else
                    {
                        string id = otp_and_code.get_code();
                        string query = $"INSERT INTO users (phone_number, Name, username, password, gender, role, status, cpu_id,unique_id) " +
                                       $"VALUES ('{phonebox.Text}', '{nmaebox.Text}', '{usernamebox.Text}', '{passbox.Text}', " +
                                       $"'{gender_check()}', '{role_check()}', 'SUSPENDED', '{log_res.GetProcessorId()}','{id}')";
                        string query1 = $"INSERT INTO student_profiles (unique_id) " +
                                       $"VALUES ('{id}')";
                        string query2 = $"INSERT INTO teacher_profiles (unique_id) " +
                                       $"VALUES ('{id}')";

                        string final_query = "";
                        if (role_check() == "STUDENT")
                        {
                            final_query = query1;
                        }
                        else if (role_check() == "TEACHER")
                        {
                            final_query = query2;
                        }



                        int res = databse.ExecuteNonQuery(query);
                        int res1 = databse.ExecuteNonQuery(final_query);

                        if (res > 0 && res1>0)
                        {
                           
                            MessageBox.Show("Registration  Successfull");
                        }
                        else
                        {
                            MessageBox.Show("Signup failed. Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists");
                }
            }
        }


        private void returnbt_click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }



        private string gender_check()
        {
            if (gender_male.Checked)
            {
                return gender_male.Text.ToString();
            }
            else if(gender_female.Checked)
            {
                return gender_female.Text.ToString();
            }
            else
            {
                return "";
            }
        }





        private string role_check()
        {
            if (role_student.Checked)
            {
                return role_student.Text.ToString();
            }
            else if(role_teacher.Checked)
            {
                return role_teacher.Text.ToString();
            }
            else
            {
                return "";
            }
        }


        private bool valid_user(string username)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE username = '{username}'";
            int count = (int)databse.ExecuteScalar(query);
            if (count == 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
