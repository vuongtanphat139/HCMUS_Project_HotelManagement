using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO_HotelManagement
{
    public class BookingForm_DAO
    {        
        private static BookingForm_DAO instance;
        public static BookingForm_DAO Instance
        {
            get
            {
                if (instance == null) instance = new BookingForm_DAO();
                return BookingForm_DAO.instance;
            }
            private set { BookingForm_DAO.instance = value; }
        }
        private BookingForm_DAO() { }
        public bool check_Booking(BookingForm_DTO BookingID)
        {
            string query = "SELECT * FROM BOOKING_FORM WHERE ID_BOOKING = '" + BookingID.IdBooking + "' AND STATUS != N'Đã xử lý'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count <= 0)
            {
                return false;
            }
            else return true;
        }
        public DataTable LoadData(BookingForm_DTO BookingID)
        {  
            string query = "SELECT R.* \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN ROOM R ON R.ID_ROOM = BR.ID_ROOM \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getGuestName(BookingForm_DTO BookingID)
        {
            string query = "SELECT C.NAME\n" +
                           "FROM BOOKING_FORM BF\n" +
                           "JOIN CUSTOMER C \n" +
                           "ON BF.CUSTOMER = C.ID_CUSTOMER\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["NAME"].ToString();
                return username;
            }
            return null;
        }
        public string getNumberofrooms(BookingForm_DTO BookingID)
        {
            string query = "SELECT COUNT(*) as Amount \n" +
                           "FROM BOOKING_FORM BF\n" +
                           "JOIN BOOKING_ROOM BR\n" +
                           "ON BF.ID_BOOKING = BR.ID_BOOKING\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["Amount"].ToString();
                return username;
            }
            return null;
        }
        public string getPaymenMethods(BookingForm_DTO BookingID)
        {
            string query = "SELECT PAYMENT_METHODS\n" +
                           "FROM BOOKING_FORM BF\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string methods;
            foreach (DataRow dr in dt.Rows)
            {
                methods = dr["PAYMENT_METHODS"].ToString();
                return methods;
            }
            return null;
        }
        public string getNoIdentity(BookingForm_DTO BookingID)
        {
            string query = "SELECT C.IDENTIFY_CARD \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "JOIN CUSTOMER C \n" +
                           "ON BF.CUSTOMER = C.ID_CUSTOMER \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["IDENTIFY_CARD"].ToString();
                return username;
            }
            return null;
        }
        public string getSPRequires(BookingForm_DTO BookingID)
        {
            string query = "SELECT SPECIAL_REQUIREMENTS \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["SPECIAL_REQUIREMENTS"].ToString();
                return username;
            }
            return null;
        }
        public string getPrice(BookingForm_DTO BookingID)
        {
            string query = "SELECT PRICE \n" +
                           "FROM BOOKING_FORM BF\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["PRICE"].ToString();
                return username;
            }
            return null;
        }
        public DateTime getDateIn(BookingForm_DTO BookingID)
        {
            string query = "SELECT ARRIVAL_DATE \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DateTime inDate;
            foreach (DataRow dr in dt.Rows)
            {
                inDate = Convert.ToDateTime(dr["ARRIVAL_DATE"]);
                return inDate;
            }
            return DateTime.Today;
        }
        public DateTime getDateOut(BookingForm_DTO BookingID)
        {
            string query = "SELECT DEPARTURE_DATE \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DateTime inDate;
            foreach (DataRow dr in dt.Rows)
            {
                inDate = Convert.ToDateTime(dr["DEPARTURE_DATE"]);
                return inDate;
            }
            return DateTime.Today.AddMonths(1);
        }

        public bool Update_BookingForm(BookingForm_DTO BookingID)
        {
            string query = "UPDATE BOOKING_FORM\n" +
                           "SET STATUS = N'Đã xử lý', SPECIAL_REQUIREMENTS = N'" + BookingID.SpecialRequirement + "', PAYMENT_METHODS = N'" + BookingID.PaymentMethods + "'\n" +
                           "WHERE ID_BOOKING = '" + BookingID.IdBooking + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public DataTable getListRoom(BookingForm_DTO BookingID)
        {
            string query = "SELECT R.NAME, R.PRICE, R.TYPE FROM BOOKING_FORM BF \n" +
                           "JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN ROOM R ON R.ID_ROOM = BR.ID_ROOM \n" +
                           "WHERE BF.ID_BOOKING = N'" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public List<string> getListRoomOfBooking(BookingForm_DTO BookingID)
        {
            string query = "SELECT R.NAME FROM BOOKING_FORM BF \n" +
                           "JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN ROOM R ON R.ID_ROOM = BR.ID_ROOM \n" +
                           "WHERE BF.ID_BOOKING = N'" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> listRoom = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                string roomName = dr["Name"].ToString();
                listRoom.Add(roomName);
            }
            return listRoom;
        }
        public string getBillID(BookingForm_DTO BookingID)
        {
            string query = "SELECT B.ID_BILL \n" +
                           "FROM BILL B \n" +
                           "WHERE B.ID_BOOKING = N'" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idBill;
            foreach (DataRow dr in dt.Rows)
            {
                idBill = dr["ID_BILL"].ToString();
                return idBill;
            }
            return null;
        }
    }
}
