using DTO_HoTelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class DiscountPromotion_DAO
    {
        private static DiscountPromotion_DAO instance;
        public static DiscountPromotion_DAO Instance
        {
            get
            {
                if (instance == null) instance = new DiscountPromotion_DAO();
                return DiscountPromotion_DAO.instance;
            }
            private set { DiscountPromotion_DAO.instance = value; }
        }
        private DiscountPromotion_DAO() { }

        public DataTable LoadDataDiscount()
        {
            string query = "SELECT  * FROM DISCOUNT_PROMOTION WHERE (END_TIME >= GETDATE()) AND (START_TIME <= GETDATE());\r\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable SearchDataDiscount(DiscountPromotion_DTO discountDate, string IDService)
        {
            string query = "SELECT * FROM DISCOUNT_PROMOTION WHERE (END_TIME >= '" + discountDate.StartTime + "') AND (START_TIME <= '" + discountDate.EndTime + "') " +
                           "AND ID_DISCOUNT IN (SELECT ID_DISCOUNT FROM DISCOUNT_SERVICE WHERE ID_SERVICE = N'"+IDService +"')";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<string> getDiscountID()
        {
            string query = "SELECT ID_DISCOUNT FROM DISCOUNT_PROMOTION WHERE (END_TIME >= GETDATE()) AND (START_TIME <= GETDATE()) \n ORDER BY ID_DISCOUNT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> discountList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string discountID = row["ID_DISCOUNT"].ToString();
                discountList.Add(discountID);
            }
            return discountList;
        }
        public bool removeDiscountID(DiscountPromotion_DTO discountID)
        {
            string subquery = "DELETE FROM DISCOUNT_SERVICE WHERE ID_DISCOUNT = N'" + discountID.IdDiscount + "'";
            string query = "DELETE FROM DISCOUNT_PROMOTION WHERE ID_DISCOUNT = N'" + discountID.IdDiscount+  "'";

            int subindex = DataProvider.Instance.ExecuteNonQuery(subquery);
            int index = DataProvider.Instance.ExecuteNonQuery(query);

            if (index > 0 && subindex > 0) return true;
            return false;
        }
        public bool addDiscount(DiscountPromotion_DTO discountID)
        {
            string query = "EXEC USP_ADDDISCOUNT N'" + discountID.Name + "', '" + discountID.StartTime + "', '" + discountID.EndTime + "', N'" + discountID.Description + "', N'" + discountID.TypeDiscount + "'," + discountID.Requirement + ", " + discountID.DiscountRate;
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public bool updateDiscount(DiscountPromotion_DTO discountID)
        {
            string query = "EXEC USP_UPDATEDISCOUNT N'" + discountID.IdDiscount + "', N'" + discountID.Name + "', '" + discountID.StartTime + "', '" + discountID.EndTime + "', N'" + discountID.Description + "', N'" + discountID.TypeDiscount + "'," + discountID.Requirement + ", " + discountID.DiscountRate;
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public string getDiscountInfo(DiscountPromotion_DTO discountID)
        {
            string query = "SELECT * FROM DISCOUNT_PROMOTION WHERE ID_DISCOUNT = N'" + discountID.IdDiscount + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            string discountString = "";
            foreach (DataRow row in dt.Rows)
            {
                discountString = row["NAME"].ToString() + "\n"+ row["START_TIME"].ToString() + "\n" + row["END_TIME"].ToString() + "\n" +
                                 row["DESCRIPTION"].ToString() + "\n" + row["TYPEDISCOUNT"].ToString() + "\n" +
                                 row["REQUIREMENT"].ToString() + "\n" + row["DISCOUNT_RATE"].ToString();
                return discountString;
            }
            return null;
        }
    }
}
