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
    public partial class NoticeCheck_inForm : Form
    {
        public NoticeCheck_inForm()
        {
            InitializeComponent();
            display();
        }
        public void display()
        {
            ServiceHotel_DataGid.DataSource = HotelService_BUS.LoadDataServiceHotel();
            Rules_DataGrid.DataSource = Rules_BUS.LoadDataRK();
        }

        public void ShowDiscountOfService(string selectedID)
        {
            HotelService_DTO IdService = new HotelService_DTO(selectedID);
            if (HotelService_BUS.LoadDataDiscountService(IdService).Rows.Count <= 0)
            {
                MessageBox.Show("Dịch vụ không có chương trình khuyến mãi");
                Discount_DataGrid.DataSource = null;
                return;
            }
            Discount_DataGrid.DataSource = HotelService_BUS.LoadDataDiscountService(IdService);
        }

        private void ServiceHotel_DataGid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ServiceHotel_DataGid.Columns["ID_Service"].Index && e.RowIndex >= 0)
            {
                string selectedID = ServiceHotel_DataGid.Rows[e.RowIndex].Cells["ID_Service"].Value.ToString();
                ShowDiscountOfService(selectedID);
            }
        }

        private void Confirm_Button_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hoàn thành thủ tục Check-in!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                ServiceForm viewService = new ServiceForm();
                viewService.Show();
            }
            else
            {
                return;
            }
        }
    }
}