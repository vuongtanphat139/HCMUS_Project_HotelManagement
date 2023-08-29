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

namespace HotelManagement
{
    public partial class Service_Coupon : Form
    {
        Customer_DTO cus;
        Room_DTO room;
        HotelService_DTO service;
        bool isFee;
        DiscountPromotion_DTO discountPromotion;
        BookingForm_DTO bookingForm_;
        Employee_DTO emp;
        int quantity;
        float rate;
        float endtotal;
        float total;
        int price;
        public Service_Coupon()
        {
            InitializeComponent();
        }
        public Service_Coupon(Customer_DTO cus, BookingForm_DTO bookingForm, Room_DTO room, HotelService_DTO service, bool isFee, DiscountPromotion_DTO discount, Employee_DTO emp)
        {
            InitializeComponent();
            this.cus = cus;
            this.room = room;
            this.service = service;
            this.isFee = isFee;
            this.discountPromotion = discount;
            this.bookingForm_ = bookingForm;
            this.emp = emp;
           
            txbQuantity.Text = "1";
            if (!isFee)
            {
                lb1.Visible = false;
                lb2.Visible = false;
                lb3.Visible = false;
                lb4.Visible = false;
                lb5.Visible = false;
                lb6.Visible = false;
                cbxNow.Visible = false;
                cbxWhenCheckout.Visible = false;
                txbOffer.Text = "Not Fee";
                price = 0;
            }
            else
            {
                price = service.price;
                if (discountPromotion.DiscountRate == 0)
                {
                    txbOffer.Text = "Không có";
                }
                else
                    txbOffer.Text = discountPromotion.Name;
            }
            txbCusName.Text = cus.Name;
            txbRoomId.Text = room.IdRoom;
            txbPhone.Text = cus.Phone;
            txbPrice.Text = service.price.ToString();
            txbUnir.Text = service.unit;
            txbServiceName.Text = service.name;
            txbDiscount.Text = discountPromotion.DiscountRate.ToString();
            txbUsingTime.Text = DateTime.Today.ToString();




        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txbQuantity.Text != "")
            {
                quantity = Int32.Parse(txbQuantity.Text);
                txbTotal.Text = (quantity * service.price).ToString();
                total = (quantity * service.price);
                if (quantity >= discountPromotion.Requirement)
                {
                    txbSubsidise.Text = (discountPromotion.DiscountRate * quantity * service.price / 100).ToString();
                    endtotal = ((1 - discountPromotion.DiscountRate / 100) * quantity * service.price);
                    txbEndtotal.Text = endtotal.ToString();
                }
                else
                {
                    txbSubsidise.Text = "0";
                    endtotal = (quantity * service.price);
                    txbEndtotal.Text = endtotal.ToString();
                }
            }
            else
            {
                quantity = 0;
                endtotal = 0;
                txbSubsidise.Text = "";
                txbEndtotal.Text = "";
                txbTotal.Text = "";
            }


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Service_Form_DTO sf;
            Service_Bill_DTO sb;
            //fix
            emp = new Employee_DTO("EMP00");
            sf = new Service_Form_DTO("",txbServiceName.Text,txbServiceName.Text,price, quantity, service.idService, emp.IdEmp, cus.IdCustomer);
            sb = new Service_Bill_DTO("", total, txbUsingTime.Text, float.Parse(txbDiscount.Text), "", bookingForm_.IdBooking, cus.IdCustomer);

            int res = Services_for_customer_BUS.usp_AddServiceCoupon(sf, sb, emp);
            if (res != 0)
            {
                MessageBox.Show("Order successfully!");
            }
            else MessageBox.Show("Order fail!");
        }
    }
}
