using DAO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Bill_BUS
    {
        public static bool updateBill(Bill_DTO billInfo)
        {
            return Bill_DAO.Instance.updateBill(billInfo);
        }
        public static string getBillInfo(Bill_DTO billInfo)
        {
            return Bill_DAO.Instance.getBillInfo(billInfo);
        }
    }
}
