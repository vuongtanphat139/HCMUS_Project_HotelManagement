using BUS_HotelManagement;
using DTO_HoTelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class addRuleForm : Form
    {
        bool check = true;
        Rules_DTO rules = new Rules_DTO();
        public addRuleForm()
        {
            InitializeComponent();
            Type_ComboBox.Text = Type_ComboBox.Items[0].ToString();
        }
        public addRuleForm(Rules_DTO ruleID)
        {
            InitializeComponent();
            check = false;
            rules = ruleID;
            ruleName_Text.Text = Rules_BUS.getNameRuleID(ruleID);
            Description_Text.Text = Rules_BUS.getDesRuleID(ruleID);
            if (ruleID.IdRule.Contains("RK"))
            {
                Type_ComboBox.Text = "Quy định chìa khóa";
            }
            else
            {
                Type_ComboBox.Text = "Quy định khách sạn";
            }
            Type_ComboBox.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (check)
            {
                DialogResult result = MessageBox.Show("Xác nhận thêm quy định!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string ruleName = ruleName_Text.Text;
                    string Descript = Description_Text.Text;
                    string type = Type_ComboBox.Text;

                    Rules_DTO addRules = new Rules_DTO(ruleName, Descript, null);
                    bool flag = Rules_BUS.addRules(addRules, type);
                    if (flag)
                    {
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại, thông tin không chính xác!");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác nhận cập nhật quy định!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string ruleName = ruleName_Text.Text;
                    string Descript = Description_Text.Text;

                    Rules_DTO updateRules = new Rules_DTO(rules.IdRule, ruleName, Descript, null);
                    bool flag = Rules_BUS.updateRules(updateRules);
                    if (flag)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại, thông tin không chính xác!");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (check)
            {
                ruleName_Text.Text = "";
                Description_Text.Text = "";
                Type_ComboBox.Text = Type_ComboBox.Items[0].ToString();
            }
            else
            {
                ruleName_Text.Text = Rules_BUS.getNameRuleID(rules);
                Description_Text.Text = Rules_BUS.getDesRuleID(rules);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
