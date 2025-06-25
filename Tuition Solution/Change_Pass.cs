using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Solution
{
    public partial class Change_Pass : Form
    {
        private string unique_id;
        private string name;
        public Change_Pass(string unique_id, string name)
        {
            InitializeComponent();
            this.unique_id = unique_id;
            this.name = name;
        }

        private void Change_Pass_Load(object sender, EventArgs e)
        {
            namebox.Text = $"Chnage Password for {name}";

        }


        private void submit_bt_Click(object sender, EventArgs e)
        {
            if ((pass.Text == "") || confirmpass.Text == "")
            {
                MessageBox.Show("Please fill all fields");

            }
            else
            {
                if (pass.Text != confirmpass.Text)
                {
                    MessageBox.Show("New password and confirm password do not match");

                }
                else
                {
                    string query = $" update users set password = '{pass.Text}' where [unique_id] = '{unique_id}'";
                    int res = databse.ExecuteNonQuery(query);
                    if (res > 0)
                    {
                        MessageBox.Show("Password changed successfully.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to change password.");
                    }
                }
            }

        }



        private void back_bt_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Change_Pass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
