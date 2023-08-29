using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Item_DAO
    {
        private static Item_DAO instance;
        public static Item_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Item_DAO();
                return Item_DAO.instance;
            }
            private set { Item_DAO.instance = value; }
        }
        private Item_DAO() { }
        public string getItemPrice(Item_DTO ItemInfo)
        {
            string query = "SELECT PRICE FROM ITEM \n " +
                           "WHERE NAME = N'" + ItemInfo.Name + "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string priceItem;
            foreach (DataRow dr in dt.Rows)
            {
                priceItem = dr["PRICE"].ToString();
                return priceItem;
            }
            return null;
        }
    }
}