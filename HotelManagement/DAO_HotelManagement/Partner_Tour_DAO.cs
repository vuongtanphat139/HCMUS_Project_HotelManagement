using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Partner_Tour_DAO
    {
        private static Partner_Tour_DAO instance;
        public static Partner_Tour_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Partner_Tour_DAO();
                return Partner_Tour_DAO.instance;
            }
            private set { Partner_Tour_DAO.instance = value; }
        }
        private Partner_Tour_DAO() { }
        public DataTable LoadDataServiceTour()
        {
            string query = "SELECT * FROM PARTNER_TOUR";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
