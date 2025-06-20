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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuition_Solution
{
    public partial class Student_Dashboard : Form
    {
        private string name;
        private string phone;
        private string unique_id;
        private string teacher_id;
        public Student_Dashboard(string name, string phone, string unique_id)
        {
            this.name = name;
            this.phone = phone;
            this.unique_id = unique_id;
            InitializeComponent();
        }
        public Student_Dashboard()
        {

        }


        private void Student_Dashboard_Load(object sender, EventArgs e)
        {
            full_name.Text = $"Welcome {name}";
            selest_subject.Items.Add("OP2");
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
    tp.address AS Address,
    tp.teacher_id As [Teacher ID]
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
                teacher_id = row.Cells["Teacher ID"].Value.ToString();
            }
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

        private void load_subjext()
        {
            string query = "SELECT subject_name FROM subjects";
            SqlDataReader red = databse.ExecuteReader(query);
            while (red.Read())
            {
                selest_subject.Items.Add(red["subject_name"].ToString());
            }
        }



        private void request_bt_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string subject = selest_subject.SelectedItem.ToString();
            string res_id = otp_and_code.get_otp();

            string query = $@"INSERT INTO teacher_requests (request_id,student_id,teacher_id,subject,request_date,time,salary,status)
            VALUES ('{res_id}', '{unique_id}','{teacher_id}','{subject}','{date}','{time_student.Text}','{salary_for_teacher.Text}','{"PENDING"}')";
            int res = databse.ExecuteNonQuery(query);
            string query1 = $"update student_profiles set request_id = ('{res_id}')  WHERE student_id = '{unique_id}'";
            string query2 = $"update teacher_profiles set request_id = ('{res_id}')  WHERE teacher_id = '{teacher_id}'";
            int res1 = databse.ExecuteNonQuery(query1);
            int res2 = databse.ExecuteNonQuery(query2);
            if (res > 0 && res1 > 0 && res2 > 0)
            {
                MessageBox.Show("Request sent successfully.");
            }
            else
            {
                MessageBox.Show("Failed to send request. Please try again.");
            }



        }



        private void search_bt_Click(object sender, EventArgs e)
        {
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
where tp.qualification = '{searchbox.Text}'
";
            SqlDataReader red = databse.ExecuteReader(query);

            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }




        private void update_bt_Click(object sender, EventArgs e)
        {
            string email = emailbox_user.Text;
            string address = addressbox_user.Text;
            string query = $"UPDATE student_profiles SET email_id = '{email}', address = '{address}' WHERE unique_id = '{unique_id}'";
            string query1 = $"UPDATE users SET phone_number = '{phonebox_user.Text}', Name = '{namebox_user.Text}' WHERE unique_id = '{unique_id}'";
            int res = databse.ExecuteNonQuery(query1);
            int res1 = databse.ExecuteNonQuery(query);
            if (res > 0 && res1 > 0)
            {
                MessageBox.Show("Profile updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.");
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
    u.Name AS [Teacher Name],
    al.subject as Subject,
    u.phone_number AS [Phone Number],
    tp.qualification AS Qualification,
    tp.address AS Address,
    al.request_id AS [Request ID]
    
FROM
    users u
        JOIN
    teacher_profiles tp ON u.unique_id = tp.teacher_id
        JOIN
    allocations al ON tp.request_id = al.request_id
where al.status = 'ACCEPT' and al.student_id= '{unique_id}'";
            SqlDataReader red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();

            var alo = new Allocation(red, dt, name);
            alo.Show();

        }



        private void delete_account_Click(object sender, EventArgs e)
        {

            string query = $@"
    delete from allocations where student_id = '{unique_id}';
    delete from student_profiles where student_id = '{unique_id}';
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
            var change_pass = new Change_Pass(unique_id,name);
            change_pass.Show();

        }
    }

}
