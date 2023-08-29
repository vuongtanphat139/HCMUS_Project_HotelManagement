using DAO_HotelManagement;
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
    public class Rules_DAO
    {
        public static Rules_DAO instance;
        public static Rules_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Rules_DAO();
                return Rules_DAO.instance;
            }
            private set { Rules_DAO.instance = value; }
        }
        private Rules_DAO() { }
        public DataTable LoadDataRK()
        {
            string query = "SELECT R.* \n" +
                           "FROM RULES R \n" +
                           "WHERE R.ID_RULE LIKE 'RK%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LoadDataOthers()
        {
            string query = "SELECT R.* \n" +
                           "FROM RULES R \n" +
                           "WHERE R.ID_RULE NOT LIKE 'RK%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LoadData()
        {
            string query = "SELECT R.* \n" +
                           "FROM RULES R";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<string> getRulesID_RK()
        {
            string query = "SELECT R.ID_RULE \n" +
                           "FROM RULES R \n"+
                           "WHERE R.ID_RULE LIKE 'RK%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> listID = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string ruleID = row["ID_RULE"].ToString();
                listID.Add(ruleID);
            }
            return listID;
        }
        public List<string> getRulesID_Others()
        {
            string query = "SELECT R.ID_RULE \n" +
                           "FROM RULES R \n" +
                           "WHERE R.ID_RULE NOT LIKE 'RK%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> listID = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string ruleID = row["ID_RULE"].ToString();
                listID.Add(ruleID);
            }
            return listID;
        }
        public List<string> getRulesID()
        {
            string query = "SELECT R.ID_RULE \n" +
                           "FROM RULES R \n" +
                           "ORDER BY R.ID_RULE";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> listID = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string ruleID = row["ID_RULE"].ToString();
                listID.Add(ruleID);
            }
            return listID;
        }
        public bool removeRulesID(Rules_DTO ruleID)
        {
            string query = "DELETE FROM RULES WHERE ID_RULE = N'" + ruleID.IdRule + "'";

            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public bool addRules(Rules_DTO ruleID, string type)
        {
            string query = "EXEC USP_AddRULES N'" + ruleID.Name + "', N'" + ruleID.Content + "', N'" + type +  "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public string getNameRuleID(Rules_DTO ruleID)
        {
            string query = "SELECT R.NAME \n" +
                           "FROM RULES R \n" +
                           "WHERE R.ID_RULE = N'"+ ruleID.IdRule +"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string name;
            foreach (DataRow dr in dt.Rows)
            {
                name = dr["NAME"].ToString();
                return name;
            }
            return null;
        }
        public string getDesRuleID(Rules_DTO ruleID)
        {
            string query = "SELECT R.CONTENT \n" +
                           "FROM RULES R \n" +
                           "WHERE R.ID_RULE = N'" + ruleID.IdRule + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string descript;
            foreach (DataRow dr in dt.Rows)
            {
                descript = dr["CONTENT"].ToString();
                return descript;
            }
            return null;
        }
        public bool updateRules(Rules_DTO ruleID)
        {
            string query = "UPDATE RULES \n" +
                           "SET NAME = N'" + ruleID.Name + "', CONTENT = N'" + ruleID.Content + "'\n" +
                           "WHERE ID_RULE = N'"+ ruleID.IdRule + "'";
            
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
    }
}