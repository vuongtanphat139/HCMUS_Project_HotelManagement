using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class HotelService_DAO
    {
        private static HotelService_DAO instance;
        public static HotelService_DAO Instance
        {
            get
            {
                if (instance == null) instance = new HotelService_DAO();
                return HotelService_DAO.instance;
            }
            private set { HotelService_DAO.instance = value; }
        }
        private HotelService_DAO() { }
        public DataTable LoadDataServiceHotel_Sub()
        {
            string query = "SELECT * FROM HOTEL_SERVICE WHERE STATUS = N'Khả dụng' AND TYPE = N'Dịch vụ hậu cần'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LoadDataServiceHotel()
        {
            string query = "SELECT * FROM HOTEL_SERVICE WHERE STATUS = N'Khả dụng'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LoadDataServiceHotel_Bus()
        {
            string query = "SELECT * FROM HOTEL_SERVICE WHERE STATUS = N'Khả dụng' AND TYPE = N'Dịch vụ kinh doanh'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LoadDataDiscountService(HotelService_DTO ServiceId)
        {
            string query = "SELECT DP.* FROM HOTEL_SERVICE HS\n" +
                           "JOIN DISCOUNT_SERVICE DS ON HS.ID_SERVICE = DS.ID_SERVICE\n" +
                           "JOIN DISCOUNT_PROMOTION DP ON DP.ID_DISCOUNT = DS.ID_DISCOUNT\n" +
                           "WHERE HS.ID_SERVICE = '" + ServiceId.IdService + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "ORDER BY DP.ID_DISCOUNT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<string> getServiceName()
        {
            string query = "SELECT NAME FROM HOTEL_SERVICE WHERE STATUS = N'Khả dụng'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> serviceList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string serviceName = row["NAME"].ToString();
                serviceList.Add(serviceName);
            }
            return serviceList;
        }
        public List<string> getServiceID()
        {
            string query = "SELECT ID_SERVICE FROM HOTEL_SERVICE WHERE STATUS = N'Khả dụng'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> serviceList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string serviceID = row["ID_SERVICE"].ToString();
                serviceList.Add(serviceID);
            }
            return serviceList;
        }
        public bool disableService(HotelService_DTO ServiceId)
        {
            string query = "UPDATE HOTEL_SERVICE \n" +
                           "SET STATUS = 'Tạm ngưng' \n" +
                           "WHERE NAME = N'" + ServiceId.Name + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public bool addService(HotelService_DTO ServiceId)
        {
            string query = "EXEC USP_AddSERVICE N'" + ServiceId.Name + "', N'" + ServiceId.Description + "', " + ServiceId.Price + ", N'" + ServiceId.Unit + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public bool updateService(HotelService_DTO ServiceId)
        {
            string query = "UPDATE HOTEL_SERVICE \n" +
                           "SET DESCRIPTION = N'" + ServiceId.Description + "', PRICE = " + ServiceId.Price + ", UNIT = N'" + ServiceId.Unit + "'\n" +
                           "WHERE NAME = N'" + ServiceId.Name +"'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public string getServicePrice(HotelService_DTO ServiceId)
        {
            string query = "SELECT HS.PRICE\n" +
                           "FROM HOTEL_SERVICE HS\n" +
                           "WHERE HS.NAME = '" + ServiceId.Name+ "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string price;
            foreach (DataRow dr in dt.Rows)
            {
                price = dr["PRICE"].ToString();
                return price;
            }
            return null;
        }
        public string getServiceDiscript(HotelService_DTO ServiceId)
        {
            string query = "SELECT HS.DESCRIPTION\n" +
                           "FROM HOTEL_SERVICE HS\n" +
                           "WHERE HS.NAME = '" + ServiceId.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string Descript;
            foreach (DataRow dr in dt.Rows)
            {
                Descript = dr["DESCRIPTION"].ToString();
                return Descript;
            }
            return null;
        }
        public string getServiceUnit(HotelService_DTO ServiceId)
        {
            string query = "SELECT HS.UNIT\n" +
                           "FROM HOTEL_SERVICE HS\n" +
                           "WHERE HS.NAME = '" + ServiceId.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string Unit;
            foreach (DataRow dr in dt.Rows)
            {
                Unit = dr["UNIT"].ToString();
                return Unit;
            }
            return null;
        }
    }
}
