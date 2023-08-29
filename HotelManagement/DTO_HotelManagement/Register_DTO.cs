using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Register_DTO
    {
        private string idCustomer;
        private string idTour;

        public string IdCustomer { get => idCustomer; set => idCustomer=value; }
        public string IdTour { get => idTour; set => idTour=value; }

        public Register_DTO(string idCustomer, string idTour)
        {
            this.idCustomer = idCustomer;
            this.idTour = idTour;
        }
    }
}
