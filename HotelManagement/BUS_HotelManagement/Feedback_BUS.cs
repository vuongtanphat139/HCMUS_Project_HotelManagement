using DAO_HotelManagement;
using DTO_HoTelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Feedback_BUS
    {
        public static bool addFeedback(Feedback_DTO fb)
        {
            return Feedback_DAO.Instance.addFeedback(fb);
        }
        public static string getMaxID()
        {
            return Feedback_DAO.Instance.getMaxID();
        }
    }
}
