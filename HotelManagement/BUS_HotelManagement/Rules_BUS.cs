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
    public class Rules_BUS
    {
        public static DataTable LoadDataRK()
        {
            return Rules_DAO.Instance.LoadDataRK();
        }
        public static DataTable LoadDataOthers()
        {
            return Rules_DAO.Instance.LoadDataOthers();
        }
        public static DataTable LoadData()
        {
            return Rules_DAO.Instance.LoadData();
        }
        public static List<string> getRulesID()
        {
            return Rules_DAO.Instance.getRulesID();
        }
        public static List<string> getRulesID_Others()
        {
            return Rules_DAO.Instance.getRulesID_Others();
        }
        public static List<string> getRulesID_RK()
        {
            return Rules_DAO.Instance.getRulesID_RK();
        }
        public static bool removeRulesID(Rules_DTO ruleID)
        {
            return Rules_DAO.Instance.removeRulesID(ruleID);
        }
        public static bool addRules(Rules_DTO ruleID, string type)
        {
            return Rules_DAO.Instance.addRules(ruleID, type);
        }
        public static string getNameRuleID(Rules_DTO ruleID)
        {
            return Rules_DAO.Instance.getNameRuleID(ruleID);
        }
        public static string getDesRuleID(Rules_DTO ruleID)
        {
            return Rules_DAO.Instance.getDesRuleID(ruleID);
        }
        public static bool updateRules(Rules_DTO ruleID)
        {
            return Rules_DAO.Instance.updateRules(ruleID);
        }
    }
}
