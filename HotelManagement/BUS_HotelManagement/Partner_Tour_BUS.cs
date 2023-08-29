using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Partner_Tour_BUS
    {
        public static DataTable LoadDataServiceTour()
        {
            return Partner_Tour_DAO.Instance.LoadDataServiceTour();
        }
    }
}
