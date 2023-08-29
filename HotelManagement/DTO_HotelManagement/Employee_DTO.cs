using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Employee_DTO
    {
        private string idEmp;
        private string name;
        private string birthDay;
        private string email;
        private string address;
        private string phone;
        private string identityCard;
        private string role;

        public string IdEmp { get => idEmp; set => idEmp = value; }
        public string Name { get => name; set => name = value; }
        public string BirthDay { get => birthDay; set => birthDay = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string IdentityCard { get => identityCard; set => identityCard = value; }
        public string Role { get => role; set => role = value; }
        public Employee_DTO(string idemp)
        {
            this.IdEmp = idemp;

        }
    }
  
}


