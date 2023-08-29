using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GUI_HotelManagement
{

    public partial class login_GUI : Form
    {

        public login_GUI()
        {
            InitializeComponent();
        }

        public static string name = "EMP11";
        public static string pass = "1234";
        public static string id = "";

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*
            if (String.IsNullOrWhiteSpace(tb_User.Text)
               || String.IsNullOrWhiteSpace(tb_Pass.Text))
            {
                MessageBox.Show("Tài khoản và mặt khẩu không được để trông!");
                return;
            }

            name = tb_User.Text.ToString();
            pass = tb_Pass.Text.ToString();
            //type = comboBox_type.Text.ToString();
            */

            bool flag = Account_DAO.Instance.Login(name, pass);

            //if (flag == 1 && type.Equals("Đối tác"))
            if (flag == true)
            {
                MessageBox.Show("Login successful!");
                //this.Hide();
                Dashboard_GUI dashboard_GUI = new Dashboard_GUI();
                dashboard_GUI.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {

        }
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkbox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_ShowPass.Checked == true)
            {
                tb_Pass.UseSystemPasswordChar = false;
            }
            else
                tb_Pass.UseSystemPasswordChar = true;
        }
    }
}
