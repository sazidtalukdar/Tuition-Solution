using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tuition_Solution
{
    public partial class show_teacher_student : Form
    {
        private string unique_id;
        private string name;
        private bool flag;
        public show_teacher_student(bool flag)
        {
            InitializeComponent();
            this.flag = flag;

        }

        private void show_teacher_student_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                activate.Visible = true;
                delete.Visible = false;
            }
            else
            {
                activate.Visible = false;
                delete.Visible = true;

            }


            string query = @"select * from users where status = 'ACTIVE' and role = 'TEACHER' or role = 'SUDENT' ";
            SqlDataReader red = databse.ExecuteReader(query);
            DataTable dt = new DataTable();
            dt.Load(red);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }


        private void delete_bt(object sender, EventArgs e)
        {
            string query = $@"delete from users where unique_id = '{unique_id}' ;
delete from student_profile where unique_id = '{unique_id}' or delete from teacher_profile where unique_id = '{unique_id}';
delete from allocarions where student_id = '{unique_id}' or delete from allocations where teacher_id = '{unique_id}';
";
        }


        private void back_bt(object sender, EventArgs e)
        {
            var admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();


        }

        private void activate_Click(object sender, EventArgs e)
        {
            string query = $"update users set cpu_id = 'cut' where unique_id = '{unique_id}'";
            int result = databse.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show($"Successfully activated {name}");
                var admin = new Admin_Dashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to activate user.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            unique_id = row.Cells["unique_id"].Value.ToString();
            name = row.Cells["Name"].Value.ToString();
            namebox.Text = name;
            
        }
    }
}
