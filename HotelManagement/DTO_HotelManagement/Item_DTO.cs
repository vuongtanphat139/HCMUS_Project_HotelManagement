using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Item_DTO
    {
        private string idItem;
        private string name;
        private int  amount;
        private string type;
        private string storageLocation;
        private string itemFunction;
        private string checkOutDate;
        private string manager;

        public string IdItem { get => idItem; set => idItem = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Type { get => type; set => type = value; }
        public string StorageLocation { get => storageLocation; set => storageLocation = value; }
        public string ItemFunction { get => itemFunction; set => itemFunction = value; }
        public string CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public string Manager { get => manager; set => manager = value; }

        public Item_DTO(string name) {
            this.name = name;
        }
    }
}

