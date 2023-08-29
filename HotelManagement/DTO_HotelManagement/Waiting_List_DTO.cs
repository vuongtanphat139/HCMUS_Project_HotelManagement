using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Waiting_List_DTO
    {
        private string idCustomer;

        public string IdCustomer { get => idCustomer; set => idCustomer=value; }
        public Waiting_List_DTO(string idCustomer)
        {
            this.idCustomer=idCustomer;
        }
    }
}
