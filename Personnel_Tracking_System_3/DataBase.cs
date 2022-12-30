using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personnel_Tracking_System_3
{
    class DataBase
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-7JR81D4O\\SABRI;Initial Catalog=Personnel_Table;Integrated Security=True");
        SqlCommand Command = new SqlCommand();
        public string Username(string user)
        {
            user = "meliha";          
            return user;
        }
        public string UserPassword(string password)
        {
            password = "1971";
            return password;

        }
        public string Admin_name(string admin)
        {
            admin = "sabri";
            return admin;
        } 
        public string Admin_password(string A_Password)
        {
            A_Password = "2001";
            return A_Password;
        }
    }
}
