using BUS_HotelManagement;
using DAO_HotelManagement;
using DTO_HoTelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            display();
        }
        public void display()
        {
            Rule_ComboBox.Text = Rule_ComboBox.Items[0].ToString();
            Rules_DataGrid.DataSource = Rules_BUS.LoadData();
        }

        public void setComboBoxID(string selectedValue)
        {
            if (selectedValue == "Quy định chìa khóa")
            {
                Rule_ComboBox.Text = selectedValue;
                Rules_DataGrid.DataSource = Rules_BUS.LoadDataRK();
                rulesId_ComboBox.DataSource = Rules_BUS.getRulesID_RK();
                //UD_Panel.Hide();
                //UD_Panel.Show();
            }
            else if (selectedValue == "Quy định khách sạn")
            {
                Rule_ComboBox.Text = selectedValue;
                Rules_DataGrid.DataSource = Rules_BUS.LoadDataOthers();
                rulesId_ComboBox.DataSource = Rules_BUS.getRulesID_Others();
                //UD_Panel.Hide();
                //UD_Panel.Show();
            }
            else
            {
                Rule_ComboBox.Text = selectedValue;
                Rules_DataGrid.DataSource = Rules_BUS.LoadData();
                rulesId_ComboBox.DataSource = Rules_BUS.getRulesID();
                //UD_Panel.Hide();
                //UD_Panel.Show();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addRuleForm addRule = new addRuleForm();
            addRule.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Rule_ComboBox.Text = "All";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string ruleID = rulesId_ComboBox.Text;
            Rules_DTO idRule = new Rules_DTO(ruleID);
            addRuleForm updateRule = new addRuleForm(idRule);
            updateRule.ShowDialog();
        }

        private void rulesId_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rule_ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = Rule_ComboBox.SelectedItem.ToString();
            setComboBoxID(selectedValue);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string RuleId = rulesId_ComboBox.Text;

            Rules_DTO idRules = new Rules_DTO(RuleId);
            bool flag = Rules_BUS.removeRulesID(idRules);

            if (flag)
            {
                MessageBox.Show("Xóa thành công!");
                foreach (DataGridViewRow row in Rules_DataGrid.Rows)
                {
                    if (row.Cells["ID_RULE"].Value.ToString() == RuleId)
                    {
                        Rules_DataGrid.Rows.Remove(row);
                        break;
                    }
                }
                setComboBoxID(Rule_ComboBox.Text);
                return;
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
                return;
            }
        }

        private void Rules_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
