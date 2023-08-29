using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Customer_Tour_DTO
    {
        private string idCustomerTour;
        private string startDate;
        private int numberParticipant;
        private int price;
        private string travelMethod;
        private string status;
        private string idTourOrigin;
        private string idCustomer;
        public string IdCustomerTour { get => idCustomerTour; set => idCustomerTour = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public int NumberParticipant { get => numberParticipant; set => numberParticipant = value; }
        public int Price { get => price; set => price = value; }
        public string TravelMethod { get => travelMethod; set => travelMethod = value; }
        public string Status { get => status; set => status = value; }
        public string IdTourOrigin { get => idTourOrigin; set => idTourOrigin = value; }
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }

        public Customer_Tour_DTO(string idCustomerTour, string startDate, int numberParticipant, int price, string travelMethod, string status, string idTourOrigin, string idCustomer)
        {
            this.idCustomerTour = idCustomerTour;
            this.startDate = startDate;
            this.numberParticipant = numberParticipant;
            this.price = price;
            this.travelMethod = travelMethod;
            this.status = status;
            this.idTourOrigin = idTourOrigin;
            this.IdCustomer = idCustomer;
        }
        public Customer_Tour_DTO()
        {

        }
    }
}