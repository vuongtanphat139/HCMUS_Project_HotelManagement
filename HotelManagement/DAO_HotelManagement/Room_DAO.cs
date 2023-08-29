using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Room_DAO
    {
        private static Room_DAO instance;
        public static Room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Room_DAO();
                return Room_DAO.instance;
            }
            private set { Room_DAO.instance = value; }
        }
        private Room_DAO() { }
        public List<string> getListRoom()
        {
            string query = "SELECT * FROM ROOM\n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n";
                roomList.Add(roomNumber);
            }
            return roomList;
        }

        public List<string> getListFRoom(string floor)
        {
            string query = "SELECT * FROM ROOM\n" +
                           "WHERE NAME LIKE N'Phòng " + floor + "%'" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }

        public DataTable getRoomService(Room_DTO RoomName)
        {
            string query = "SELECT HS.* FROM ROOM R\n " +
                           "JOIN ROOM_SERVICE RS ON R.ID_ROOM = RS.ID_ROOM\n" +
                           "JOIN HOTEL_SERVICE HS ON HS.ID_SERVICE = RS.ID_SERVICE\n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getRoomService_Bus(Room_DTO RoomName)
        {
            string query = "SELECT HS.* FROM ROOM R\n " +
                           "JOIN ROOM_SERVICE RS ON R.ID_ROOM = RS.ID_ROOM\n" +
                           "JOIN HOTEL_SERVICE HS ON HS.ID_SERVICE = RS.ID_SERVICE\n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "AND HS.TYPE = N'Dịch vụ kinh doanh' \n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getRoomService_Sub(Room_DTO RoomName)
        {
            string query = "SELECT HS.* FROM ROOM R\n " +
                           "JOIN ROOM_SERVICE RS ON R.ID_ROOM = RS.ID_ROOM\n" +
                           "JOIN HOTEL_SERVICE HS ON HS.ID_SERVICE = RS.ID_SERVICE\n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "AND HS.TYPE = N'Dịch vụ hậu cần' \n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<string> getListItems(Room_DTO RoomInfo)
        {
            string query = "select I.NAME from ROOM R \n" +
                           "join ITEM_ROOM IR on R.ID_ROOM = IR.ID_ROOM \n" +
                           "join ITEM I on I.ID_ITEM = IR.ID_ITEM \n" +
                           "WHERE R.NAME = N'" + RoomInfo.Name + "'\n" +
                           "ORDER BY I.NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> listItems= new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["NAME"].ToString();
                listItems.Add(name);
            }
            return listItems;
        }
        public DataTable getRoomItems(Room_DTO RoomName)
        {
            string query = "select I.NAME, I.ITEM_FUNCTION, I.TYPE, IR.AMOUNT from ROOM R \n" +
                           "join ITEM_ROOM IR on R.ID_ROOM = IR.ID_ROOM \n" +
                           "join ITEM I on I.ID_ITEM = IR.ID_ITEM \n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "ORDER BY I.NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getRoomStatus(Room_DTO RoomName)
        {
            string query = "SELECT STATUS FROM ROOM \n " +
                           "WHERE NAME = N'" + RoomName.Name + "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string statusRoom;
            foreach (DataRow dr in dt.Rows)
            {
                statusRoom = dr["STATUS"].ToString();
                return statusRoom;
            }
            return null;
        }
        public string getRoomPrice(Room_DTO RoomName)
        {
            string query = "SELECT PRICE FROM ROOM \n " +
                           "WHERE NAME = N'" + RoomName.Name + "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string priceRoom;
            foreach (DataRow dr in dt.Rows)
            {
                priceRoom = dr["PRICE"].ToString();
                return priceRoom;
            }
            return null;
        }
        public List<string> getListRoom(string filterStatus, string filterType)
        {
            string query = "";
            if(filterStatus == "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "ORDER BY NAME ASC";
                
            }
            else if(filterStatus != "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "ORDER BY NAME ASC";
            }
            else if(filterStatus == "All" && filterType != "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE TYPE = N'" + filterType + "'\n" +
                        "ORDER BY NAME ASC";
            }
            else
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "AND TYPE = N'" + filterType + "'\n" +
                        "ORDER BY NAME ASC";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n";
                roomList.Add(roomNumber);
            }
            return roomList;
        }

        public List<string> getListRoomFilter_Status(string filterStatus, string filterType)
        {
            string query = "";
            if (filterStatus == "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "ORDER BY STATUS DESC";

            }
            else if (filterStatus != "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n";
            }
            else if (filterStatus == "All" && filterType != "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE TYPE = N'" + filterType + "'\n" +
                        "ORDER BY STATUS DESC";
            }
            else
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "AND TYPE = N'" + filterType + "'\n";
            }
             
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n" + row["STATUS"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }
        public List<string> getListRoomFilter_Type(string filterStatus, string filterType)
        {
            string query = "";
            if (filterStatus == "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "ORDER BY TYPE ASC";

            }
            else if (filterStatus != "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "ORDER BY TYPE ASC"; ;
            }
            else if (filterStatus == "All" && filterType != "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE TYPE = N'" + filterType + "'\n";
            }
            else
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "AND TYPE = N'" + filterType + "'\n";
            }

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n" + row["TYPE"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }
        public string getRoomInformation(Room_DTO RoomName)
        {
            string query = "SELECT *\n" +
                           "FROM ROOM \n" +
                           "WHERE NAME = '" + RoomName.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idRoom;
            foreach (DataRow dr in dt.Rows)
            {
                idRoom = dr["ID_ROOM"].ToString() + "\n" + dr["TYPE"].ToString() + "\n" +
                         dr["PRICE"].ToString() + "\n" + dr["STATUS"].ToString() + "\n";
                return idRoom;
            }
            return null;
        }
        public string getCustomerRoomInformation(Room_DTO RoomName)
        {
            string query = "SELECT C.ID_CUSTOMER, C.NAME, C.GENDER, CONVERT(DATE,C.BIRTHDAY) AS BIRTHDAY, C.EMAIL, C.PHONE, C.IDENTIFY_CARD\n" +
                           "FROM ROOM R\n" +
                           "JOIN BOOKING_ROOM BR ON BR.ID_ROOM = R.ID_ROOM \n" +
                           "JOIN BOOKING_FORM BF ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN CUSTOMER C ON C.ID_CUSTOMER = BF.CUSTOMER \n" +
                           "WHERE R.NAME = '" + RoomName.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string cusInfo;
            foreach (DataRow dr in dt.Rows)
            {
                cusInfo =dr["ID_CUSTOMER"].ToString() + "\n" + dr["NAME"].ToString() + "\n" + dr["GENDER"].ToString() + "\n" +
                         dr["BIRTHDAY"].ToString() + "\n" + dr["EMAIL"].ToString() + "\n" +
                         dr["PHONE"].ToString() + "\n" + dr["IDENTIFY_CARD"].ToString() + "\n";
                return cusInfo;
            }
            return null;
        }
        public bool updatePriceRoom(Room_DTO roomPrice)
        {
            string query = "UPDATE ROOM \n" +
                           "SET PRICE = " + roomPrice.Price + "\n" +
                           "WHERE NAME = N'" + roomPrice.Name + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if(index <= 0) { return false; }
            return true;
        }
        public bool updateStatusRoom(Room_DTO roomName, string newStatus)
        {
            string query = "UPDATE ROOM \n" +
                           "SET STATUS = N'" + newStatus + "'\n" +
                           "WHERE NAME = N'" + roomName.Name + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
    }
}
