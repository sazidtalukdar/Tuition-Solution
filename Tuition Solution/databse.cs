using System;
using System.Data;
using System.Data.SqlClient;

namespace Tuition_Solution
{
    public class databse
    {
        private static readonly string _connectionString = "Server=localhost;Database=C#;User Id=sa;Password=sazid999;";

      

        public static int ExecuteQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString)) {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                //conn.Close();
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }
}
