using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Customer_DAO
    {
        private static Customer_DAO instance;
        public static Customer_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Customer_DAO();
                return Customer_DAO.instance;
            }
            private set { Customer_DAO.instance = value; }
        }
        private Customer_DAO() { }
        public bool updateCustomer(Customer_DTO CusInfo)
        {
            string query = "UPDATE CUSTOMER \n" +
                           "SET NAME = N'" + CusInfo.Name + "', GENDER = N'" + CusInfo.Gender + "', BIRTHDAY = CONVERT(DATE, '" + CusInfo.Birthday + "', 103), EMAIL = N'" + CusInfo.Email +
                           "', PHONE = '" + CusInfo.Phone + "', IDENTIFY_CARD = N'" + CusInfo.Identify_Card + "' \n" +
                           "WHERE ID_CUSTOMER = N'" + CusInfo.IdCustomer +"'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0){ return false;}
            return true;
        }
        public DataTable getUsedService(Customer_DTO CusInfo)
        {
            string query = "SELECT SF.NAME, SB.USED_DATE, SF.PRICE, SF.AMOUNT, SB.DISCOUNT, SB.TOTAL_PRICE FROM CUSTOMER C \n" +
                           "JOIN SERVICE_FORM SF ON C.ID_CUSTOMER = SF.CUSTOMER \n" +
                           "JOIN SERVICE_BILL SB ON SB.ID_SERVICE_FORM = SF.ID_SERVICE_FORM \n" +
                           "WHERE C.NAME = N'" + CusInfo.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getCusID_Booking(Customer_DTO cusInfo)
        {
            string query = "SELECT BF.ID_BOOKING FROM BOOKING_FORM BF \n" +
                           "JOIN CUSTOMER C ON C.ID_CUSTOMER = BF.CUSTOMER \n" +
                           "JOIN BILL B ON B.ID_BOOKING = BF.ID_BOOKING \n" +
                           "WHERE C.NAME = N'" + cusInfo.Name + "' \n" +
                           "AND B.STATUS != N'Đã thanh toán' AND STATUS == N'Đã xử lý'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idBooking;
            foreach (DataRow dr in dt.Rows)
            {
                idBooking = dr["ID_BOOKING"].ToString();
                return idBooking;
            }
            return null;
        }
        public string getCusID_Checkin(Customer_DTO cusInfo)
        {
            string query = "SELECT BF.ID_BOOKING FROM BOOKING_FORM BF \n" +
                           "JOIN CUSTOMER C ON C.ID_CUSTOMER = BF.CUSTOMER \n" +
                           "WHERE C.NAME = N'" + cusInfo.Name + "' \n" +
                           "AND BF.STATUS != N'Đã xử lý'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idBooking;
            foreach (DataRow dr in dt.Rows)
            {
                idBooking = dr["ID_BOOKING"].ToString();
                return idBooking;
            }
            return null;
        }
        public string getCusInfo(Customer_DTO cusInfo)
        {
            string query = "SELECT C.EMAIL, C.PHONE FROM CUSTOMER C \n " +
                           "WHERE C.NAME = N'" + cusInfo.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string infoCus;
            foreach (DataRow dr in dt.Rows)
            {
                infoCus = dr["PHONE"].ToString() + '\n' + dr["EMAIL"].ToString();
                return infoCus;
            }
            return null;
        }
    }
}
