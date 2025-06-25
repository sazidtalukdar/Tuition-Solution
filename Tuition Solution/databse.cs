using System;
using System.Data;
using System.Data.SqlClient;

namespace Tuition_Solution
{
    public class databse
    {
        private static readonly string con = "Data Source=.;Initial Catalog=c#;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";//"Server=localhost;Database=C#;User Id=sa;Password=sazid999;";

        // for count
        public static int ExecuteScalar(string query)
        {
            using (SqlConnection conn = new SqlConnection(con))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if(result!= null)
                {
                    return Convert.ToInt32(result);
                }
                
            }
            return  0;
        }




        // for isert, update, delete 
        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(con))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }




        //for multiple rows
        public static SqlDataReader ExecuteReader(string query)
        {
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
