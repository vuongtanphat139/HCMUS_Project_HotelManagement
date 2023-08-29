using DTO_HoTelManagement;
//using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Services_for_customer_DAO
    {
        public static Services_for_customer_DAO instance;

        public static Services_for_customer_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Services_for_customer_DAO();
                return Services_for_customer_DAO.instance;
            }
            private set { Services_for_customer_DAO.instance = value; }
        }
        public Services_for_customer_DAO() { }

        public DataTable usp_SearchRoomByID_svs(Room_DTO roomId)
        {
            string query ="exec usp_SearchRoomByID_svs '" + roomId.IdRoom + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;

        }
        public DataTable usp_getServicesOfRoom_svs(Room_DTO roomId, HotelService_DTO hotelService_)
        {
            string query;
            if (hotelService_ == null)
            {
                query = "exec usp_getServicesOfRoom_svs '" + roomId.IdRoom + "', N'"  + "'";
            }
            query = "exec usp_getServicesOfRoom_svs '" + roomId.IdRoom + "', N'"+hotelService_.Name+ "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public HotelService_DTO usp_getDetailOfService_svs (HotelService_DTO hotelService)
        {
            string query = "exec usp_getDetailOfService_svs '" + hotelService.IdService + "'";
            HotelService_DTO hotelService_ = new HotelService_DTO();
            DataTable dt  = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                hotelService_.IdService = dr["ID_SERVICE"].ToString();
                hotelService_.Name = dr["NAME"].ToString();
                hotelService_.Price = Int32.Parse(dr["PRICE"].ToString());
                hotelService_.Unit = dr["UNIT"].ToString();
                hotelService_.Description = dr["DESCRIPTION"].ToString();
                hotelService_.Status = dr["STATUS"].ToString();
                return hotelService_;
            }
            return null;
        }
        //getCustomerByPhone
        public Customer_DTO usp_getCustomerByPhone(string phone)
        {
            string query = "exec usp_getCustomerByPhone_svs '" + phone + "'";
            Customer_DTO customer = new Customer_DTO();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                customer.IdCustomer = dr["ID_CUSTOMER"].ToString();
                customer.Name = dr["NAME"].ToString();
                customer.Phone = phone;

                return customer;
            }
            return null;
        }
        public DataTable usp_getDiscountOfService_svs(HotelService_DTO hotelService)
        {
            string query = "exec usp_getDiscountOfService_svs '" + hotelService.IdService + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public DataTable usp_getAllServices_svs(HotelService_DTO hotelService_)
        {
            string query = "exec usp_getAllServices_svs N'" + hotelService_.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public int usp_AddServiceCoupon(Service_Form_DTO service_Form, Service_Bill_DTO service_Bill, Employee_DTO emp)
        {
            // service.idbill
            string query = "exec usp_AddServiceCoupon '" + service_Form.Customer + "', N'" + service_Form.Name + "', '" + service_Form.IdService + "', N'" + service_Form.Description + "', " + service_Form.Price + ", " + service_Form.Amount + ", '" + service_Form.FormCreator + "', " + service_Bill.TotalPrice + ", '" + service_Bill.UsedDate + "', " + service_Bill.Discount +", '"+ "B0000" + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public DataTable usp_getAllDepartureList_svs()
        {
            string query = "exec usp_getAllDepartureList_svs";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable usp_getAllDestinationList_svs()
        {
            string query = "exec usp_getAllDestinationList_svs";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable usp_searchTour_svs(Partner_Tour_DTO partTour, Schedule_DTO sche, int error)
        {
            //@depart nvarchar(30),@des nvarchar(30), @leavingDate char(30),
            //@endDate char(30), @error int) 
            string query = "exec usp_searchTour_svs N'" +
                partTour.DeparturePoint + "', N'" + partTour.DestinationPoint + "', '" +
                sche.StartTime + "' ,'" + sche.EndDTime + "', '" + error + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        //usp_createTourForm_svs( @startDate varchar(30), @numPart int,
        ////@price int, @travelMethod nvarchar(20), @status nvarchar(30), 
        /////@idPartnerTour char(10), @id_cus char(10)) 
        public int usp_createTourForm_svs(Customer_Tour_DTO cusTour)
        {
            //( @startDate varchar(30), @numPart int, @price int,
            ////@travelMethod nvarchar(20),
            ////@status nvarchar(30),
            ////@idPartnerTour char(10), @id_cus char(10)) 
            string query = "exec usp_createTourForm_svs '" +
                cusTour.StartDate +"', "+ cusTour.NumberParticipant+", " + cusTour.Price+", N'" + cusTour.TravelMethod + "', N'" +
                cusTour.Status + "', '" + cusTour.IdTourOrigin + "', '" + cusTour.IdCustomer +"'";
            int res = DataProvider.Instance.ExecuteNonQuery(query);
            return res;
        }
        public DataTable usp_getServiceFormsByPhone_svs(String phone)
        {
            //@depart nvarchar(30),@des nvarchar(30), @leavingDate char(30),
            //@endDate char(30), @error int) 
            string query = "exec usp_getServiceFormsByPhone_svs '" +phone + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
