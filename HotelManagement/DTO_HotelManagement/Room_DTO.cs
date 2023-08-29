using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Room_DTO
    {
        private string idRoom;
        private string name;
        private string status;
        private int price;
        private string type;

        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }

        public Room_DTO(string _idRoom, string _name, string _status, int _price, string _type) {
            this.idRoom = _idRoom;  
            this.name = _name;
            this.status = _status;
            this.price = _price;    
            this.type = _type;  
        }
        public Room_DTO(string name)
        {
            this.name = name;
        }
        public Room_DTO() { }
        public Room_DTO(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
