using DAO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Item_BUS
    {
        public static string getItemPrice(Item_DTO ItemInfo)
        {
            return Item_DAO.Instance.getItemPrice(ItemInfo);
        }
    }
}
