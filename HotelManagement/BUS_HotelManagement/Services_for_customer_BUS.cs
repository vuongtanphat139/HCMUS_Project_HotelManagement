using DAO_HotelManagement;
using DTO_HoTelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Services_for_customer_BUS
    {
        //public Services_for_customer_BUS() { }

        public static DataTable usp_SearchRoomByID_svs(Room_DTO roomId)
        {
            return Services_for_customer_DAO.Instance.usp_SearchRoomByID_svs(roomId);
        }
        public static DataTable usp_getServicesOfRoom_svs(Room_DTO roomId, HotelService_DTO hotelService_)
        {
            return Services_for_customer_DAO.Instance.usp_getServicesOfRoom_svs(roomId, hotelService_);
        }

        public static HotelService_DTO usp_getDetailOfService_svs (HotelService_DTO hotelService)
        {
            return Services_for_customer_DAO.Instance.usp_getDetailOfService_svs(hotelService);
        }
        public static Customer_DTO usp_getCustomerByPhone(string phone)
        {
            return Services_for_customer_DAO.Instance.usp_getCustomerByPhone(phone);
        }
        public static DataTable usp_getDiscountOfService_svs(HotelService_DTO hotelService)
        {
            return Services_for_customer_DAO.Instance.usp_getDiscountOfService_svs(hotelService);
        }
        public static DataTable usp_getAllServices_svs(HotelService_DTO hotelService)
        {
            return Services_for_customer_DAO.Instance.usp_getAllServices_svs(hotelService);
        }
         public static int usp_AddServiceCoupon(Service_Form_DTO service_Form, Service_Bill_DTO service_Bill, Employee_DTO emp)
        {
            return Services_for_customer_DAO.Instance.usp_AddServiceCoupon(service_Form, service_Bill, emp);
        }


        
        public static DataTable usp_getAllDepartureList_svs()
        {
            return Services_for_customer_DAO.Instance.usp_getAllDepartureList_svs();
        }

        public static DataTable usp_getAllDestinationList_svs()
        {
            return Services_for_customer_DAO.Instance.usp_getAllDestinationList_svs();
        }
        public static DataTable usp_searchTour_svs(Partner_Tour_DTO partTour, Schedule_DTO sche, int error)
        {
            return Services_for_customer_DAO.Instance.usp_searchTour_svs(partTour, sche,  error);
        }
        public static int usp_createTourForm_svs(Customer_Tour_DTO cusTour)
        {
            return Services_for_customer_DAO.Instance.usp_createTourForm_svs(cusTour);
        }
        public static DataTable usp_getServiceFormsByPhone_svs(string phone)
        {
            return Services_for_customer_DAO.Instance.usp_getServiceFormsByPhone_svs(phone);
        }
    }
}
