using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Customer_DTO
    {
        private string idCustomer;
        private string name;
        private string gender;
        private string birthday;
        private string email;
        private string phone;
        private string identify_Card;
        private string iD_Information;
       
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Identify_Card { get => identify_Card; set => identify_Card = value; }
        public string ID_Information { get => iD_Information; set => iD_Information = value; }

        public Customer_DTO(string idcus, string name, string gender, string birthday, string email, string phone, string identify_Card)
        {
            this.idCustomer = idcus;
            this.Name = name;
            this.Gender = gender;
            this.Birthday = birthday;
            this.Email = email;
            this.Phone = phone;
            this.Identify_Card = identify_Card;
        }
        public Customer_DTO(string name)
        {
            this.name = name;
        }
        public Customer_DTO() { }
    }
}
