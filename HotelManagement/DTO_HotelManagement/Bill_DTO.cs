using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Bill_DTO
    {
        private string idBill;
        private string room_Fee;
        private string service_price;
        private string damaged_price;
        private string deposit_price;
        private string total_price;
        private string payment_methods;
        private string status;
        private string creator;
        private string idBooking;

        public string IdBill { get => idBill; set => idBill = value; }
        public string Room_Fee { get => room_Fee; set => room_Fee = value; }
        public string Service_price { get => service_price; set => service_price = value; }
        public string Damaged_price { get => damaged_price; set => damaged_price = value; }
        public string Deposit_price { get => deposit_price; set => deposit_price = value; }
        public string Total_price { get => total_price; set => total_price = value; }
        public string Payment_methods { get => payment_methods; set => payment_methods = value; }
        public string Status { get => status; set => status = value; }
        public string Creator { get => creator; set => creator = value; }
        public string IdBooking { get => idBooking; set => idBooking = value; }

        public Bill_DTO(string idBill)
        {
            this.idBill = idBill;
        }
        public Bill_DTO(string idBill, string room_Fee, string service_price, string damaged_price, string deposit_price, string total_price, string payment_methods, string status, string creator, string idBooking)
        {
            this.idBill = idBill;
            this.room_Fee = room_Fee;
            this.service_price = service_price;
            this.damaged_price = damaged_price;
            this.deposit_price = deposit_price;
            this.total_price = total_price;
            this.payment_methods = payment_methods;
            this.status = status;
            this.creator = creator;
            this.idBooking = idBooking;
        }
    }
}
