using DAO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Supply_Form_BUS
    {
        public static string getRegisterName(Supply_Form_DTO CusName)
        {
            return Supply_Form_DAO.Instance.getRegisterName(CusName);
        }
    }
}
