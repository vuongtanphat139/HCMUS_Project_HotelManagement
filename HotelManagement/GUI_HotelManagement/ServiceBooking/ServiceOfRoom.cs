using BUS_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Service_Of_Room : Form
    {
        public Room_DTO room = new Room_DTO();
        public HotelService_DTO hotelService = new HotelService_DTO("", "", "", 0, "", "");
        public Customer_DTO customer;
        public DiscountPromotion_DTO discountPromotion;
        public BookingForm_DTO bookingForm;
        public bool isAllServices = false;
        public bool isChoosedDiscount ;
        public Service_Of_Room()
        {
            InitializeComponent();
        }

        public Service_Of_Room(BookingForm_DTO bookingForm_, Room_DTO roomId, Customer_DTO cus)
        {
            room = roomId;
            this.customer = cus;
            this.bookingForm= bookingForm_;
            InitializeComponent();
            // // set up dtgv
            dtgvServiceList.RowHeadersWidth = 50;
            dtgvAllServices.RowHeadersWidth = 50;
            txbServiceName.Text = "";
            dtgvOffer.RowHeadersWidth = 50;

            dtgvAllServices.Visible = false;

            room = roomId;
            dtgvServiceList.DataSource = Services_for_customer_BUS.usp_getServicesOfRoom_svs(roomId, hotelService);
            dtgvServiceList.Columns[0].Visible = false;
            for (int i = 0; i < dtgvServiceList.Rows.Count; i++)
            {
                dtgvServiceList.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAllServices = false;
            dtgvServiceList.Visible = true;
            dtgvAllServices.Visible = false;
            string serviceName = txbServiceName.Text;
            HotelService_DTO serv = new HotelService_DTO("", serviceName, "", 0, "", "");
            dtgvServiceList.DataSource = Services_for_customer_BUS.usp_getServicesOfRoom_svs(room, serv);
            dtgvServiceList.Columns[0].Visible = false;
            for (int i = 0; i < dtgvServiceList.Rows.Count; i++)
            {
                dtgvServiceList.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    
        private void dtgvServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isAllServices = false;
            string serviceId = dtgvServiceList.Rows[e.RowIndex].Cells["ID_SERVICE"].Value.ToString();
            hotelService = new HotelService_DTO(serviceId);
            hotelService = Services_for_customer_BUS.usp_getDetailOfService_svs(hotelService);
            txbName.Text = hotelService.name;
            txtDesc.Text = hotelService.description;
            txtUnit.Text = hotelService.unit;
            txtPrice.Text = hotelService.price.ToString();
            txbStatus.Text = hotelService.Status;
            dtgvOffer.DataSource = Services_for_customer_BUS.usp_getDiscountOfService_svs(hotelService);
            dtgvOffer.Columns[0].Visible = false;
            dtgvOffer.AllowUserToAddRows = false;
            txbOffer.Text = "Not Fee";
            ;
            for (int i = 0; i < dtgvOffer.Rows.Count; i++)
            {
                dtgvOffer.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            DataGridViewCheckBoxColumn doWork = new DataGridViewCheckBoxColumn();
            doWork.HeaderText = "Applied";
            doWork.FalseValue = "0";
            doWork.TrueValue = "1";
            dtgvOffer.Columns.Insert(0, doWork);
            dtgvOffer.Columns[0].Width = 50;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Employee_DTO emp = new Employee_DTO("EMP00");
            if( !isChoosedDiscount)
            {
                discountPromotion = new DiscountPromotion_DTO("", "", "", "", "", 0, 0);
            } 
            Service_Coupon service_Coupon = new Service_Coupon(customer, bookingForm, room, hotelService, isAllServices, discountPromotion, emp);
            service_Coupon.ShowDialog();


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            isAllServices = true;
            //dtgvServiceList.Visible = false;

            string serviceName = txbServiceName.Text;
            HotelService_DTO serv = new HotelService_DTO("", serviceName, "", 0, "", "");
            dtgvAllServices.DataSource = Services_for_customer_BUS.usp_getAllServices_svs(serv);

            dtgvAllServices.Visible = true;
            //txbOffer.Text = "";
            for (int i = 0; i < dtgvAllServices.Rows.Count; i++)
            {
                dtgvAllServices.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dtgvAllServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isAllServices = true;
            string serviceId = dtgvAllServices.Rows[e.RowIndex].Cells["ID_SERVICE"].Value.ToString();
            hotelService = new HotelService_DTO(serviceId);
            hotelService = Services_for_customer_BUS.usp_getDetailOfService_svs(hotelService);
            txbName.Text = hotelService.name;
            txtDesc.Text = hotelService.description;
            txtUnit.Text = hotelService.unit;
            txtPrice.Text = hotelService.price.ToString();
            txbStatus.Text = hotelService.Status;
            dtgvOffer.DataSource = Services_for_customer_BUS.usp_getDiscountOfService_svs(hotelService);
            dtgvOffer.Columns[0].Visible = false;
            dtgvOffer.AllowUserToAddRows = false;
            isChoosedDiscount = false;
            txbOffer.Text = "Chọn một trong những chương trình khuyến mãi (nếu có) để đặt lịch.";
            ;
            for (int i = 0; i < dtgvOffer.Rows.Count; i++)
            {
                dtgvOffer.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            DataGridViewCheckBoxColumn doWork = new DataGridViewCheckBoxColumn();
            doWork.HeaderText = "Applied";
            doWork.FalseValue = "0";
            doWork.TrueValue = "1";
            dtgvOffer.Columns.Insert(0, doWork);
            dtgvOffer.Columns[0].Width = 50;
        }

        private void dtgvOffer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isChoosedDiscount = true;
            string discId = dtgvOffer.Rows[e.RowIndex].Cells["ID_DISCOUNT"].Value.ToString();
            string discName = dtgvOffer.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            string discStartTime = dtgvOffer.Rows[e.RowIndex].Cells["START_TIME"].Value.ToString();
            string discEndTime = dtgvOffer.Rows[e.RowIndex].Cells["END_TIME"].Value.ToString();
            string discRequirement = dtgvOffer.Rows[e.RowIndex].Cells["REQUIREMENT"].Value.ToString();
            string discRate = dtgvOffer.Rows[e.RowIndex].Cells["DISCOUNT_RATE"].Value.ToString();
            string discDesc = dtgvOffer.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString();
            discountPromotion = new DiscountPromotion_DTO(discId, discName, discStartTime, discEndTime,discDesc, Int32.Parse(discRequirement), float.Parse(discRate, CultureInfo.InvariantCulture.NumberFormat),0);
        }
    }
}
