using BUS_HotelManagement;
using DTO_HoTelManagement;
using GUI_HotelManagement;
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
    public partial class addServiceForm : Form
    {
        bool check = true;
        HotelService_DTO service = new HotelService_DTO();
        public addServiceForm()
        {
            InitializeComponent();
            Unit_ComboBox.Text = Unit_ComboBox.Items[0].ToString();

        }
        public addServiceForm(HotelService_DTO serviceID)
        {
            InitializeComponent();
            check = false;
            service = serviceID;
            Name_Text.Text = serviceID.Name;
            Descript_Text.Text = HotelService_BUS.getServiceDiscript(serviceID);
            Price_Text.Text = HotelService_BUS.getServicePrice(serviceID);
            Unit_ComboBox.Text = HotelService_BUS.getServiceUnit(serviceID);
        }

        private void Descript_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check)
            {
                DialogResult result = MessageBox.Show("Xác nhận thêm dịch vụ!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string serviceName = Name_Text.Text;
                    string Descript = Descript_Text.Text;
                    int Price;
                    if (Price_Text.Text == "")
                    {
                        MessageBox.Show("Chưa nhập giá trị!");
                        return;
                    }
                    else
                    {
                        Price = int.Parse(Price_Text.Text);
                    }
                    string Unit = Unit_ComboBox.Text;

                    HotelService_DTO addService = new HotelService_DTO(serviceName, Descript, Price, Unit);
                    bool flag = HotelService_BUS.addService(addService);
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
                DialogResult result = MessageBox.Show("Xác nhận cập nhật dịch vụ!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string serviceName = Name_Text.Text;
                    string Descript = Descript_Text.Text;
                    int Price = int.Parse(Price_Text.Text);
                    string Unit = Unit_ComboBox.Text;

                    HotelService_DTO addService = new HotelService_DTO(serviceName, Descript, Price, Unit);
                    bool flag = HotelService_BUS.updateService(addService);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (check)
            {
                Name_Text.Text = "";
                Descript_Text.Text = "";
                Price_Text.Text = "";
                Unit_ComboBox.Text = Unit_ComboBox.Items[0].ToString();
            }
            else
            {
                Name_Text.Text = service.Name;
                Descript_Text.Text = HotelService_BUS.getServiceDiscript(service);
                Price_Text.Text = HotelService_BUS.getServicePrice(service);
                Unit_ComboBox.Text = HotelService_BUS.getServiceUnit(service);
            }
        }

        private void Name_Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
