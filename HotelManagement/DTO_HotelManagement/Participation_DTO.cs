using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Participation_DTO
    {
        private string idCustomerTour;
        private string idCustomer;

        public string IdCustomerTour { get => idCustomerTour; set => idCustomerTour=value; }
        public string IdCustomer { get => idCustomer; set => idCustomer=value; }

        public Participation_DTO(string idCustomerTour, string idCustomer)
        {
            this.idCustomerTour = idCustomerTour;
            this.idCustomer = idCustomer;   
        }
    }
}
