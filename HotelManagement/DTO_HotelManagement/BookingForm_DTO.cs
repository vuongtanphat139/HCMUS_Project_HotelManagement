using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class BookingForm_DTO
    {
        private string idBooking;
        private string arrivalDate;
        private string departureDate;
        private int amount;
        private int price;
        private string status;
        private string specialRequirement;
        private string paymentMethods;
        private string customer;

        public string IdBooking { get => idBooking; set => idBooking = value; }
        public string ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public string DepartureDate { get => departureDate; set => departureDate = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public string SpecialRequirement { get => specialRequirement; set => specialRequirement = value; }
        public string PaymentMethods { get => paymentMethods; set => paymentMethods = value; }
        public string Customer { get => customer; set => customer = value; }

        public BookingForm_DTO(string Id)
        {
            this.idBooking = Id;
        }
        public BookingForm_DTO(string Id, string SpecialRequirement, string PaymentMethods)
        {
            this.idBooking = Id;
            this.paymentMethods= PaymentMethods;
            this.specialRequirement= SpecialRequirement;
        }
    }
}

