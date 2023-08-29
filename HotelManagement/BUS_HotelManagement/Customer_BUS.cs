using DAO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Customer_BUS
    {
        public static bool updateCustomer(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.updateCustomer(Cusinfo);
        }
        public static DataTable getUsedService(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getUsedService(Cusinfo);
        }
        public static string getCusID_Booking(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getCusID_Booking(Cusinfo);
        }
        public static string getCusInfo(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getCusInfo(Cusinfo);
        }
        public static string getCusID_Checkin(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getCusID_Checkin(Cusinfo);
        }
    }
}
