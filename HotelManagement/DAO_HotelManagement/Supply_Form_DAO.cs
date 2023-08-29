using DTO_HoTelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Supply_Form_DAO
    {
        private static Supply_Form_DAO instance;
        public static Supply_Form_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Supply_Form_DAO();
                return Supply_Form_DAO.instance;
            }
            private set { Supply_Form_DAO.instance = value; }
        }
        private Supply_Form_DAO() { }
        public string getRegisterName(Supply_Form_DTO CusName)
        {
            string query = "SELECT * FROM SUPPLY_FORM WHERE REGISTERED_NAME = N'" + CusName.RegisteredName + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            string result;
            foreach(DataRow row in dt.Rows)
            {
                result = row["GROUP_NAME"].ToString() + '\n' + row["GROUP_SIZE"].ToString();
                return result;
            }
            return null;
        }
    }
}
