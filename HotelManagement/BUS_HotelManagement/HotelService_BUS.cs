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
    public class HotelService_BUS
    {
        public static DataTable LoadDataServiceHotel()
        {
            return HotelService_DAO.Instance.LoadDataServiceHotel();
        }
        public static DataTable LoadDataServiceHotel_Sub()
        {
            return HotelService_DAO.Instance.LoadDataServiceHotel_Sub();
        }
        public static DataTable LoadDataServiceHotel_Bus()
        {
            return HotelService_DAO.Instance.LoadDataServiceHotel_Bus();
        }
        public static DataTable LoadDataDiscountService(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.LoadDataDiscountService(ServiceId);
        }
        public static List<string> getServiceName()
        {
            return HotelService_DAO.Instance.getServiceName();
        }
        public static List<string> getServiceID()
        {
            return HotelService_DAO.Instance.getServiceID();
        }
        public static bool disableService(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.disableService(ServiceId);
        }
        public static bool addService(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.addService(ServiceId);
        }
        public static bool updateService(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.updateService(ServiceId);
        }
        public static string getServicePrice(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.getServicePrice(ServiceId);
        }
        public static string getServiceDiscript(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.getServiceDiscript(ServiceId);
        }
        public static string getServiceUnit(HotelService_DTO ServiceId)
        {
            return HotelService_DAO.Instance.getServiceUnit(ServiceId);
        }
    }
}
