using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class BookingRoom_DTO
    {
        private string idBooking;
        private string idRoom;

        public string IdBooking { get => idBooking; set => idBooking = value; }
        public string IdRoom { get => idRoom; set => idRoom = value; }
    }
}
