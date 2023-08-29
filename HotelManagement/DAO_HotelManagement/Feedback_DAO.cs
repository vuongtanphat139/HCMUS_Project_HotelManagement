using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Feedback_DAO
    {
        private static Feedback_DAO instance;
        public static Feedback_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Feedback_DAO();
                return Feedback_DAO.instance;
            }
            private set { Feedback_DAO.instance = value; }
        }
        private Feedback_DAO() { }

        public string getMaxID()
        {
            string query = "SELECT MAX(STT) AS ID FROM FEEDBACK";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string STT;
            foreach (DataRow dr in dt.Rows)
            {
                STT = dr["ID"].ToString();
                return STT;
            }
            return null;
        }
        public bool addFeedback(Feedback_DTO fb)
        {
            string query = "INSERT INTO FEEDBACK VALUES (N'" + fb.IdSTT + "',N'" + fb.Content + "', '" + fb.Created_date + "', '" + fb.Rating + "','" + fb.Id_bill + "')";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
    }
}
