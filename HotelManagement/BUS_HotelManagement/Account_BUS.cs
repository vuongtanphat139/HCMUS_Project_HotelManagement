using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_HotelManagement;

namespace BUS_HotelManagement
{
    public class Account_BUS
    {
        public static bool Login(string username, string password)
        {
            return Account_DAO.Instance.Login(username, password);
        }
    }
}
