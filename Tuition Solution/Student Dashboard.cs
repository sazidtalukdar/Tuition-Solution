using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tuition_Solution
{
    public partial class Student_Dashboard : Form 
    {
        private string name;
        private string phone { get; set; }
        private string unique_id { get; set; }
        public Student_Dashboard(string name, string phone, string unique_id)
        {
            this.name = name;
            this.phone = phone;
            this.unique_id = unique_id;
            InitializeComponent();
        }
       
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {
            load_data();
            phone_teacher.Visible = false;
            qualification_teacher.Visible = false;
            address_teacher.Visible = false;
            phone_l.Visible = false;
            qualification_l.Visible = false;
            panel4.Visible = false;

 
            string query = $@"
SELECT 
    u.Name AS [Teacher Name],
    u.phone_number AS [Phone Number],
    tp.qualification AS Qualification,
    tp.address AS Address
FROM 
    users u
JOIN 
    teacher_profiles tp ON u.unique_id = tp.unique_id
";
            //WHERE 
            //u.unique_id = '{unique_id}'

            SqlDataReader red = databse.ExecuteReader(query);
            DataTable dt = new DataTable(); 

            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void qualification_l_Click(object sender, EventArgs e)
        {

        }




        private void phone_l_Click(object sender, EventArgs e)
        {

        }



        private void search_bt_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            dataGridView1.Width = 500;
            dataGridView1.Height = 500;
            panel1.Size = new Size(490, 490);



        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel4.Visible = true;
            name_teacher.Visible = true;
            phone_teacher.Visible = true;
            qualification_teacher.Visible = true;
            address_teacher.Visible = true;
            name_l.Visible = true;
            phone_l.Visible = true;
            qualification_l.Visible = true;
            adress_l.Visible = true;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                name_teacher.Text = row.Cells["Teacher Name"].Value.ToString();
                phone_teacher.Text = row.Cells["Phone Number"].Value.ToString();
                qualification_teacher.Text = row.Cells["Qualification"].Value.ToString();
                address_teacher.Text = row.Cells["Address"].Value.ToString();
            }
        }



        private void MakeButtonRound(Button button)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);
        }


        private void request_bt_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            dataGridView1.Width = 1000;
            dataGridView1.Height = 500;
            panel1.Size = new Size(990, 490);
            panel4.Visible = false;
            name_teacher.Visible = false;
            phone_teacher.Visible = false;
            qualification_teacher.Visible = false;
            address_teacher.Visible = false;
            name_l.Visible = false;
            phone_l.Visible = false;
            qualification_l.Visible = false;
            adress_l.Visible = false;


        }


        private void load_data()
        {
            string query = $"select email_id,address from student_profiles where [unique_id]= '{unique_id}'";
            SqlDataReader red = databse.ExecuteReader(query);
            if (red.Read())
            {
                namebox_user.Text = name;
                phonebox_user.Text = phone;
                emailbox_user.Text = red["email_id"].ToString();
                addressbox_user.Text = red["address"].ToString();

            }

        }



        private void update_bt_Click(object sender, EventArgs e)
        {
            string email = emailbox_user.Text;
            string address = addressbox_user.Text;
            string query = $"UPDATE student_profiles SET email_id = '{email}', address = '{address}' WHERE unique_id = '{unique_id}'";
            string query1 = $"UPDATE users SET phone_number = '{phonebox_user.Text}', Name = '{namebox_user.Text}' WHERE unique_id = '{unique_id}'";
            int res = databse.ExecuteNonQuery(query1);
            int res1 = databse.ExecuteNonQuery(query);
            if (res > 0 && res1 >0)
            {
                MessageBox.Show("Profile updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.");
            }
        }


    }

}
