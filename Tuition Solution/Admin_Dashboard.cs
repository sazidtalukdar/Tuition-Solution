using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Solution
{
    public partial class Admin_Dashboard : Form
    {
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

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            string query = @"select * from users where status = 'ACTIVE' and role = 'TEACHER' or role ='STUDENT' ";
            var red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;


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
student_profiles sp on unique_id = sp.unique_id
where u.status = 'ACTIVE' and u.role = 'STUDENT'
                ";
            var red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;

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
teacher_profiles sp on uniqu_id = sp.unique_id
where u.status = 'ACTIVE' and u.role = 'TEACHER'
                ";
            var red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;

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
            phone.Text = row.Cells["Phone"].Value.ToString();
            address.Text = row.Cells["Address"].Value.ToString();
        }


        private void delete_bt_Click(object sender, EventArgs e)
        { 
            var del = new show_teacher_student(false);
            del.Show();
        }


        private void active_device_bt_Click(object sender, EventArgs e)
        {
            var del = new show_teacher_student(true);
            del.Show();
        }



    }
}