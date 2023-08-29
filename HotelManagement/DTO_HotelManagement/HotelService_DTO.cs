using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class HotelService_DTO
    {
        public string idService;
        public string name;
        public string description;
        public int price;
        public string unit;
        public string status;

        public string IdService { get => idService; set => idService = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Status { get => status; set => status = value; }
        public HotelService_DTO()
        {
            this.idService = null;
            this.name = null;
            this.description = null;
            this.price = 0;
            this.unit = null;
            this.status = null;
    }
        public HotelService_DTO(string serviceId) {
            this.idService = serviceId;
        }
        public HotelService_DTO(string serviceID, string servicename)
        {
            this.idService = serviceID;
            this.name = servicename;
        }

        public HotelService_DTO(string servicename, string Descript, int Price, string Unit)
        {
            this.description = Descript;
            this.name = servicename;
            this.price = Price;
            this.unit = Unit;  
        }
        public HotelService_DTO(string idService, string name, string description, int price, string unit, string status)
        {
            IdService = idService;
            Name = name;
            Description = description;
            Price = price;
            Unit = unit;
            Status = status;
        }
    }
}

