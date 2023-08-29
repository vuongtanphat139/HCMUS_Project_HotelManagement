using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Partner_DTO
    {
        private string idPartner;
        private string name;
        private string phone;
        private string email;
        private string address;

        public string IdPartner { get => idPartner; set => idPartner=value; }
        public string Name { get => name; set => name=value; }
        public string Phone { get => phone; set => phone=value; }
        public string Email { get => email; set => email=value; }
        public string Address { get => address; set => address=value; }

        public Partner_DTO(string idPartner, string name, string phone, string email, string address)
        {
            this.idPartner = idPartner;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;

        }
    }
}
