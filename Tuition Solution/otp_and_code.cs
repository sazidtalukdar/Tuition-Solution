using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tuition_Solution
{
    internal class otp_and_code
    {

        public static string get_code()
        {
            var random = new Random();
            int code = random.Next(100000, 999999); 
            return $"{code}";
        }

        public static void SendSms(string number,string sms)
        {
            string apiKey = "jMlv1LIPfmMf69ATOmB5";
            string senderId = "8809617619638";

            string url = $"http://bulksmsbd.net/api/smsapi?api_key={apiKey}&type=text&number={number}&senderid={senderId}&message={sms}";

            using (WebClient client = new WebClient())
            {
                client.DownloadString(url);
                //string response = client.DownloadString(url);
                MessageBox.Show("Otp is send to your number");
            }
        }



        public static bool verify_code( string user_code , string phone_no)
        {

            String code = get_code();

            SendSms(phone_no, $"your otp is {code} Do not share your opt with onay one . Thank you");

            if (code == user_code)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
