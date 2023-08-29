using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class ItemRoom_DTO
    {
        private string idItem;
        private string idRoom;
        private int amount;

        public string IdItem { get => idItem; set => idItem = value; }
        public string IdRoom { get => idRoom; set => idRoom = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
