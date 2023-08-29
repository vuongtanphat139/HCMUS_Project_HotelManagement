using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO_HotelManagement
{
    public class Database
    {
        private SqlConnection conn;
        public Database()
        {
            string connectionString = "Data Source = (local); Initial Catalog = HotelManagement; Integrated Security = True";
            try
            {
                conn = new SqlConnection(connectionString);

            }
            catch (Exception e)
            {
                //MessageBox.Show("Failed to connect" + e.Message);
            }
        }
        public Database(string id, string password)
        {
            string connectionString = "Data Source = (local);Initial Catalog = HotelManagement ;User ID=" + id + ";Password=" + password;
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Failed to connect" + e.Message);
            }
        }
        public bool _login(string name, string password)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM TAIKHOAN where TK='" + name + "' and MK='" + 123 + "'", conn);

            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            //MessageBox.Show(dt.Rows[0][0].ToString());
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                return true;
            }
            else
                return false;
        }
        ~Database()
        {
            conn.Close();
        }
    }
}
