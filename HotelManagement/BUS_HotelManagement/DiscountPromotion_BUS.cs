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
    public class DiscountPromotion_BUS
    {
        public static DataTable LoadDataDiscount()
        {
            return DiscountPromotion_DAO.Instance.LoadDataDiscount();
        }
        public static DataTable SearchDataDiscount(DiscountPromotion_DTO discountDate, string IDService)
        {
            return DiscountPromotion_DAO.Instance.SearchDataDiscount(discountDate, IDService);
        }
        public static List<string> getDiscountID()
        {
            return DiscountPromotion_DAO.Instance.getDiscountID();
        }
        public static bool removeDiscountID(DiscountPromotion_DTO discountID)
        {
            return DiscountPromotion_DAO.Instance.removeDiscountID(discountID);
        }
        public static bool addDiscount(DiscountPromotion_DTO discountID)
        {
            return DiscountPromotion_DAO.Instance.addDiscount(discountID);
        }
        public static bool updateDiscount(DiscountPromotion_DTO discountID)
        {
            return DiscountPromotion_DAO.Instance.updateDiscount(discountID);
        }
        public static string getDiscountInfo(DiscountPromotion_DTO discountID)
        {
            return DiscountPromotion_DAO.Instance.getDiscountInfo(discountID);
        }
    }
}
