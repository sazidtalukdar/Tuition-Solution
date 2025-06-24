using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Solution
{
    public partial class Admin_Dashboard : Form
    {
        private string unique_id;
        private string name_;
        private string phone_;
        private string admin_id;
        public Admin_Dashboard(string name, string phone, string admin_id)
        {
            InitializeComponent();
            this.name_ = name;
            this.phone_ = phone;
            this.admin_id = admin_id;

        }


        public Admin_Dashboard()
        {
            InitializeComponent();
        }
        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_show_Click(object sender, EventArgs e)
        {
            pic_show.Visible = false;
            pic_hide.Visible = true;
            guna2GradientPanel1.Visible = true;
            guna2GradientPanel1.Width = 259;
        }


        private void pic_hide_Click(object sender, EventArgs e)
        {
            pic_show.Visible = true;
            pic_hide.Visible = false;
            guna2GradientPanel1.Visible = true;
            guna2GradientPanel1.Width = 55;
        }


        private void load_to_griedview() {
            string query = @"select * from users where status = 'ACTIVE' and role = 'TEACHER' or role ='STUDENT' ";
            var red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {


            load_to_griedview();
            load_admin_info();
            pic_hide.Visible = false;
            guna2GradientPanel1.Width = 55;
            picture_name.Visible = false;
            picture_phone.Visible = false;
            picture_address.Visible = false;
            name.Visible = false;
            phone.Visible = false;
            address.Visible = false;
        }



        private void active_st_Click(object sender, EventArgs e)
        {
            string query = @"select
u.Name as 'Name',
u.phone_number as 'Phone'
,u.role as 'Role',
sp.address as 'Address',
sp.email_id as 'Email'

from 
users u
join 
student_profiles sp on u.unique_id = sp.student_id
where u.status = 'ACTIVE' and u.role = 'STUDENT'
                ";
            var red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        private void active_teacher_Click(object sender, EventArgs e)
        {
            string query = @"select
u.Name as 'Name',
u.phone_number as 'Phone'
,u.role as 'Role',
sp.address as 'Address',
sp.email_id as 'Email'

from 
users u
join 
teacher_profiles sp on u.unique_id = sp.teacher_id
where u.status = 'ACTIVE' and u.role = 'TEACHER'
                ";
            var red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            picture_name.Visible = true;
            picture_phone.Visible = true;
            picture_address.Visible = true;
            name.Visible = true;
            phone.Visible = true;
            address.Visible = true;
            name.Text = row.Cells["Name"].Value.ToString(); 
            phone.Text = row.Cells["phone_number"].Value.ToString();
            //address.Text = row.Cells["Address"].Value.ToString();
            unique_id = row.Cells["unique_id"].Value.ToString();
        }


        private void delete_bt_Click(object sender, EventArgs e)
        { 
            var del = new show_teacher_student(false);
            del.Show();
            load_to_griedview();
        }


        private void active_device_bt_Click(object sender, EventArgs e)
        {
            var del = new show_teacher_student(true);
            del.Show();
        }


        private void approve_Click(object sender, EventArgs e)
        {
            string query = $"update users set status = 'ACTIVE' where status = 'SUSPENDED' and unique_id = '{unique_id}'";
            int result = databse.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Successfully approved ");
                load_to_griedview();
            }
            else
            {
                MessageBox.Show("Failed to approve users.");
            }
        }


        private void load_admin_info()
        {
            string query = "select * from admin_profile";

            using (var reader = databse.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    admin_email.Text = reader["email"].ToString();
                    admin_name.Text = name_;
                    admin_phone.Text = phone_;
                }
         
            }
        }




    }
}