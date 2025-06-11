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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }




        private void singup_click(object sender, EventArgs e)
        {
            string quary = $"insert into users (username,password,phone_number,role,status,cpu_id) values ('{userbox.Text}','{passbox.Text}','{phonebox.Text}','{role}','{saztus}','cut')";
            databse.ExecuteNonQuery(quary);

        }



    }
}
