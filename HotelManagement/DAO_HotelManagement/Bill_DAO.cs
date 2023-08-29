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
    public class Bill_DAO
    {
        private static Bill_DAO instance;
        public static Bill_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Bill_DAO();
                return Bill_DAO.instance;
            }
            private set { Bill_DAO.instance = value; }
        }
        private Bill_DAO() { }

        public bool updateBill(Bill_DTO billInfo)
        {
            string query = "UPDATE BILL \n" +
                           "SET ROOM_FEE = " + billInfo.Room_Fee.ToString() + ", SERVICE_PRICE = " + billInfo.Service_price.ToString() + "," +
                           "DAMAGED_PRICE = " + billInfo.Damaged_price.ToString() + ", DEPOSIT_PRICE = " + billInfo.Deposit_price.ToString() + "," +
                           "TOTAL_PRICE = " + billInfo.Total_price.ToString() + ", PAYMENT_METHODS = N'" + billInfo.Payment_methods.ToString() + "'," +
                           "STATUS = N'" + billInfo.Status.ToString() + "', FORM_CREATOR = N'" + billInfo.Creator.ToString() + "' \n" +
                           "WHERE ID_BILL = N'" + billInfo.IdBill + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
        public string getBillInfo(Bill_DTO billInfo)
        {
            string query = "SELECT B.STATUS, B.DEPOSIT_PRICE FROM BILL B \n" +
                           "WHERE B.ID_BILL = N'"+ billInfo.IdBill + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string billInfomation;
            foreach (DataRow dr in dt.Rows)
            {
                billInfomation = dr["DEPOSIT_PRICE"].ToString() + "\n" + dr["STATUS"].ToString();
                return billInfomation;
            }
            return null;
        }

    }
}
