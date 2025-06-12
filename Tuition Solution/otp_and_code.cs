using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tuition_Solution
{
    internal class otp_and_code
    {
        private string otp;

        public  string get_code()
        {
            var random = new Random();
            int code = random.Next(100000, 999999); 
            return $"{code}";
        }

        public void SendSms(string number, string sms)
        {
            string query = $"select apikey,senderid from api ";

            SqlDataReader reader = databse.ExecuteReader(query);

            if (reader.Read())
            {
                string apiKey = reader["apikey"].ToString();
                string senderId = reader["senderid"].ToString();

                string url = $"http://bulksmsbd.net/api/smsapi?api_key={apiKey}&type=text&number={number}&senderid={senderId}&message={sms}";

                using (WebClient client = new WebClient())
                {
                    client.DownloadString(url);
                    //string response = client.DownloadString(url);
                    MessageBox.Show("Otp is send to your number");
                    reader.Close();
                }
            }
        }

        public void set_code(string code)
        {
            this.otp = code;
        }



        public bool verify_code( string user_code)
        {
            return otp == user_code;
        }
    }
}
