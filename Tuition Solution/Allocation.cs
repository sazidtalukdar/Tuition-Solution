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
    public partial class Allocation : Form
    {
        private SqlDataReader red;
        private DataTable dt;
        private string name;
        private string allocation_id;
        public Allocation(SqlDataReader red, DataTable dt, string name)
        {
            InitializeComponent();
            this.red = red;
            this.dt = dt;
            this.name = name;
        }


        private void Allocation_Load(object sender, EventArgs e)
        {
            dt.Load(red);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            namebox.Text = $"Allocation Of {name}";
        }


        private void back_bt_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM allocations WHERE [allocation_id] = '{allocation_id}'";
            int result = databse.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Allocation deleted successfully.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to delete allocation . ");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                allocation_id = row.Cells["allocation_id"].Value.ToString();
            }
        }

        private void Allocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
