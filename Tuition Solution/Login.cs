﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Tuition_Solution
{
    public partial class Login : Form
    {
        private string name { get;set;}
        private string phone { get; set; }
        private string role { get; set; }
        private string status { get; set; }
        private string cpu_id { get; set; }
        private string cpu_db_id { get; set; }
        private string unique_id { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            string cpu_id_l = log_res.GetProcessorId();
            this.cpu_id = cpu_id_l;

        }

        private void login_bt_click(object sender, EventArgs e)

        {


            string query1 = $"SELECT * FROM users WHERE [username] = '{userbox.Text}' AND password = '{textBox1.Text}'";
            string query = $"SELECT COUNT(*) FROM users WHERE [username] = '{userbox.Text}' AND password = '{textBox1.Text}'";
            SqlDataReader reader = databse.ExecuteReader(query1);

            int count = databse.ExecuteScalar(query);

            if (userbox.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");

            }
            else
            {

                if (count == 1)
                {
                    if (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string phone = reader["phone_number"].ToString();
                        string gender = reader["gender"].ToString() ;
                        string role = reader["role"].ToString();
                        string status = reader["status"].ToString();
                        string cpu = reader["cpu_id"].ToString();
                        string qunique_id = reader["unique_id"].ToString();
                        this.name=name;
                        this.phone = phone;
                        this.role = role;
                        this.status = status;
                        this.cpu_db_id = cpu;
                        this.unique_id = qunique_id;


                    }

                    if (cpu_db_id == "cut")
                    {
                        string query2 = $"update users set cpu_id = '{cpu_id}' where username = '{userbox.Text}'";
                        databse.ExecuteNonQuery(query2);
                        this.cpu_db_id = cpu_id;
                    }
                    if (cpu_id != cpu_db_id)
                    {
                        MessageBox.Show("This computer is not registered for your account. Please contact the admin.");
                        return;
                    }
                    else
                    {

                        if (status == "ACTIVE")
                        {
                            MessageBox.Show("Login successful!");
                            if (role == "ADMIN")
                            {
                                var s = new registration();
                                s.Show();
                                this.Hide();

                            }
                            else if (role == "TEACHER")
                            {

                            }
                            else if (role == "STUDENT")
                            {
                                var s = new Student_Dashboard(name,phone,unique_id);
                                s.Show();
                                this.Hide();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Your account is not active. Please contact the admin.");
                        }
                    }
                }

                else
                {
                    MessageBox.Show(" Wrong username or password.");
                }
            }
        }


        private void create_click(object sender, EventArgs e)
        {
            var r = new registration();
            r.Show();
            this.Hide();
        }




        private void show_pass_click(object sender, EventArgs e)
        {
            if (show_pass.Checked)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }



        private void forgot_click(object sender, EventArgs e)
        {
            var f = new Forgot();
            f.Show();
            this.Hide();
        }


        private void passbox_click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                textBox1.PasswordChar = '*';
            }

        }




    }   
}
