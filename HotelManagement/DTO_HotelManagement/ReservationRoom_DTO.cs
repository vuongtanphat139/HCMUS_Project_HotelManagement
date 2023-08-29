using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class ReservationRoom_DTO
    {
        private string idRoom;
        private string arrivalDate;
        private string departureDate;

        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public string DepartureDate { get => departureDate; set => departureDate = value; }
    }
}

