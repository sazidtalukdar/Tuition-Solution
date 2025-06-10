using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Tuition_Solution
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void login_bt_click(object sender, EventArgs e)
        {

            string query = $"SELECT COUNT(*) FROM users WHERE [name] = '{userbox.Text}' AND password = '{passbox.Text}'";

               int count = databse.ExecuteQuery(query);

               if (count == 1)
            {
                MessageBox.Show(" Login successful ");
            }
             else
            {
                MessageBox.Show(" Wrong username or password.");
            }
        }






        private void signupButton_Click(object sender, EventArgs e)
        {
         
        }




    }
}
