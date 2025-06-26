using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Tuition_Solution
{
    public partial class teacher_desh : Form, inertface
    {

        private string name;
        private string phone;
        private string unique_id;
        private string student_id;
        private string request_id;
        private string student_name;
        private string student_phone;
        public teacher_desh(string name, string phone, string unique_id)
        {

            this.name = name;
            this.phone = phone;
            this.unique_id = unique_id;
            InitializeComponent();
        }



        private void pic_show_Click(object sender, EventArgs e)
        {
            pic_show.Visible = false;
            pic_hide.Visible = true;
            guna2GradientPanel1.Visible = true;
            guna2GradientPanel1.Width = 259;
            picture_name.Visible = false;
            picture_phone.Visible = false;
            picture_qualification.Visible = false;
            picture_address.Visible = false;
            phone_teacher.Visible = false;
            //qualification_teacher.Visible = false;
            address_teacher.Visible = false;
            name_teacher.Visible = false;
            address_teacher.Visible = false;
            id_box.Visible = false;
        }


        private void pic_hide_Click(object sender, EventArgs e)
        {
            pic_show.Visible = true;
            pic_hide.Visible = false;
            guna2GradientPanel1.Visible = true;
            guna2GradientPanel1.Width = 55;

            picture_name.Visible = true;
            picture_phone.Visible = true;
            picture_qualification.Visible = true;
            picture_address.Visible = true;

            phone_teacher.Visible = true;
            qualification_teacher.Visible = true;
            address_teacher.Visible = true;
            name_teacher.Visible = true;
            id_box.Visible = true;


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            guna2GradientPanel1.Width = 55;
            pic_hide.Visible = false;
            pic_show.Visible = true; // need to change
            name_teacher.Visible = true;
            phone_teacher.Visible = true;
            address_teacher.Visible = true;
            time_student.Visible = true;
            salary_for_teacher.Visible = true;
            picture_name.Visible = true;
            picture_phone.Visible = true;
            picture_address.Visible = true;
            id_box.Visible = true;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                name_teacher.Text = row.Cells["Student Name"].Value.ToString();
                student_name = row.Cells["Student Name"].Value.ToString();
                phone_teacher.Text = row.Cells["Phone Number"].Value.ToString();
                student_phone = row.Cells["Phone Number"].Value.ToString();
                subject_box.Text = row.Cells["Subject"].Value.ToString();
                address_teacher.Text = row.Cells["Address"].Value.ToString();
                student_id = row.Cells["Student ID"].Value.ToString();
                time_student.Text = row.Cells["Time"].Value.ToString();
                salary_for_teacher.Text = row.Cells["Salary"].Value.ToString();
                request_id = row.Cells["Request ID"].Value.ToString();
            }
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            guna2GradientPanel1.Width = 55;
            pic_hide.Visible = false;
            pic_show.Visible = true; // need to change
            name_teacher.Visible = true;
            phone_teacher.Visible = true;
            address_teacher.Visible = true;
            time_student.Visible = true;
            salary_for_teacher.Visible = true;
            picture_name.Visible = true;
            picture_phone.Visible = true;
            picture_address.Visible = true;
            id_box.Visible = true;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                name_teacher.Text = row.Cells["Student Name"].Value.ToString();
                student_name= row.Cells["Student Name"].Value.ToString();
                phone_teacher.Text = row.Cells["Phone Number"].Value.ToString();
                student_phone = row.Cells["Phone Number"].Value.ToString();
                subject_box.Text = row.Cells["Subject"].Value.ToString();
                address_teacher.Text = row.Cells["Address"].Value.ToString();
                student_id = row.Cells["Student ID"].Value.ToString();
                time_student.Text = row.Cells["Time"].Value.ToString();
                salary_for_teacher.Text = row.Cells["Salary"].Value.ToString();
                request_id = row.Cells["Request ID"].Value.ToString();
            }
        }



        private void update_bt_Click(object sender, EventArgs e)
        {
            string email = emailbox_user.Text;
            string address = addressbox_user.Text;
            string query = $"update teacher_profiles SET email_id = '{email}', address = '{address}', qualification = '{qualification_teacher.Text}' WHERE unique_id = '{unique_id}'";
            string query1 = $"update users SET phone_number = '{phonebox_user.Text}', Name = '{namebox_user.Text}' WHERE unique_id = '{unique_id}'";
            int res = databse.ExecuteNonQuery(query1);
            int res1 = databse.ExecuteNonQuery(query);
            if (res > 0 && res1 > 0)
            {
                MessageBox.Show("Profile updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update profil.");
            }
        }



        private void logout_bt_click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }



        private void allocatin_bt_click(object sender, EventArgs e)
        {
            string query = $@"SELECT
    u.Name AS [Student Name],
    u.role As [Role],
    al.subject as Subject,
    u.phone_number AS [Phone Number],
    al.time AS [Time],
    al.salary AS [Salary],
    sp.address AS Address,
    al.allocation_id 
    
FROM
    users u
        JOIN
    student_profiles sp ON u.unique_id = sp.student_id
        JOIN
    allocations al ON sp.student_id = al.student_id
where al.status = 'ACTIVE' and al.teacher_id= '{unique_id}'";
            SqlDataReader red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();

            var alo = new Allocation(red, dt, name);
            alo.Show();

        }



        private void delete_account_Click(object sender, EventArgs e)
        {

            string query = $@"
    delete from allocations where teacher_id = '{unique_id}';
    delete from teacher_profiles where teacher_id = '{unique_id}';
    delete from users where unique_id = '{unique_id}';
";

            int res = databse.ExecuteNonQuery(query);
            if (res > 0)
            {
                MessageBox.Show("Account deleted successfully.");
                var login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to delete account.");
            }
        }



        private void change_pass_Click(object sender, EventArgs e)
        {
            var change_pass = new Change_Pass(unique_id, name);
            change_pass.Show();

        }



        private void search_bt_Click(object sender, EventArgs e)
        {
            if (searchbox.Text != "")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;

                string query = $@"
     select    u.Name AS [Student Name],
    al.subject as Subject,
    u.phone_number AS [Phone Number],
    al.time AS [Time],
    al.salary AS [Salary],
    sp.address AS Address,
    sp.student_id as [Student ID] ,
    al.request_id as [Request ID]
    from
    users u
    join 
    student_profiles sp ON u.unique_id = sp.student_id
    join
 teacher_requests al ON al.student_id = sp.student_id
where al.teacher_id = '{unique_id}' and al.subject= '{searchbox.Text}'";

                using (SqlDataReader red = databse.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(red);
                    dataGridView2.DataSource = dt;

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
            else
            {
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;

            }

        }


        private void load_data()
        {
            string query = $@"
            select 
            tp.email_id,
            tp.address,
            tp.qualification 
            from 
            teacher_profiles tp
            join 
            users u on u.unique_id = tp.unique_id 
            where u.unique_id = '{unique_id} '
            ";

            SqlDataReader red = databse.ExecuteReader(query);
            if (red.Read())
            {
                namebox_user.Text = name;
                phonebox_user.Text = phone;
                emailbox_user.Text = red["email_id"].ToString();
                addressbox_user.Text = red["address"].ToString();
                qualification_teacher.Text = red["qualification"].ToString();

            }

        }

        private void accept_bt_Click(object sender, EventArgs e)
        {
            string query = $@"
insert into allocations (allocation_id,student_id,teacher_id,subject,request_date,time,salary,status)
select request_id,student_id,teacher_id,subject,request_date,time,salary,status
from teacher_requests
where request_id = '{request_id}' and teacher_id = '{unique_id}';

delete from teacher_requests where request_id = '{request_id}' and teacher_id = '{unique_id}';

update allocations set status = 'ACTIVE' where allocation_id = '{request_id}' and teacher_id = '{unique_id}';
";
            int res = databse.ExecuteNonQuery(query);
            if (res > 0)
            {
                MessageBox.Show("Allocation accepted successfully.");
                student_request_load();
                string sms = $"Dear {student_name},\nYour request for tuition has been accepted. Please contact the teacher for further details.\nThank you.";
                otp_and_code sms_code = new otp_and_code();
                sms_code.SendSms(student_phone, sms);

            }
            else
            {
                MessageBox.Show("Failed to accept allocation.");
            }

        }



        private void reject_bt_Click(object sender, EventArgs e)
        {
            string query = $"delete from teacher_requests where teacher_id= '{unique_id}'  and request_id='{request_id}'";
            int res = databse.ExecuteNonQuery(query);
            if (res > 0)
            {
                MessageBox.Show("Request rejected successfully.");
                student_request_load();
            }
            else
            {
                MessageBox.Show("Failed to reject request.");
            }
        }



        private void teacher_desh_Load(object sender, EventArgs e)
        {
            id_box.Visible = false;
            id_box.Text = $"ID {unique_id}";
            load_data();
            inertface inter = this;
            inter.student_request_load();
            dataGridView2.Visible = false;


        }



        private void student_request_load()
        {
            string query = $@"
select
    u.Name as [Student Name],
    u.phone_number as [Phone Number],
   al.subject as Subject,
    al.time as [Time],
    al.salary as [Salary],
    sp.address AS Address,
    sp.student_id as [Student ID],
    al.request_id as [Request ID]
from 
    users u
join
    student_profiles sp ON u.unique_id = sp.unique_id
join
teacher_requests al on al.student_id = sp.student_id

where al.status = 'PENDING' and u.role = 'STUDENT' and al.teacher_id = '{unique_id}'
";

            SqlDataReader red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();

            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void teacher_desh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void inertface.student_request_load()
        {
            student_request_load();
        }




    }
       
    }
