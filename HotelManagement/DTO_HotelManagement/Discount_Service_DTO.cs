using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{

    public class Discount_Service_DTO
    {
        private string idDiscount;
        private string idService;

        public string IdDiscount { get => idDiscount; set => idDiscount=value; }
        public string IdService { get => idService; set => idService=value; }

        public Discount_Service_DTO(string idDiscount, string idService)
        {
            this.idDiscount = idDiscount;
            this.idService=idService;
        }
    }

}
