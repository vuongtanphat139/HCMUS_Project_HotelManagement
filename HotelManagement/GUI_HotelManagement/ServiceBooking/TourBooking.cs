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
    public partial class Tour_Booking : Form
    {
        Customer_DTO cus;
        Customer_Tour_DTO cusTour;
        Schedule_DTO schedule;
        Partner_Tour_DTO partTour;
        public Tour_Booking()
        {
            InitializeComponent();
        }
        public Tour_Booking(Customer_DTO cus, Partner_Tour_DTO partTour, Customer_Tour_DTO cusTour, Schedule_DTO schedule)
        {
            InitializeComponent();
            this.cus = cus;
            this.cusTour = cusTour;
            this.schedule = schedule;
            this.partTour = partTour;
            tbDeparture.Text = partTour.DeparturePoint.ToString();
            tbDepartureTime.Text = schedule.StartTime.ToString();
            //tbPhone.Text = cus.Phone.ToString();
            tbProgess.Text = cusTour.Status.ToString();
            tbTourName.Text = partTour.Name.ToString();
            tbDesination.Text = partTour.DestinationPoint.ToString();
            tbPartner.Text= partTour.Description.ToString();
            //tbRegister.Text = cus.Name.ToString();

        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tour_Booking_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTourForm_Click(object sender, EventArgs e)
        {
            cusTour = new Customer_Tour_DTO("", schedule.StartTime, int.Parse(tbNumPart.Text), cusTour.Price, tbTravelMethod.Text, "Đang chờ phản hồi từ đối tác du lịch", cusTour.IdTourOrigin, cus.IdCustomer);
            int res = Services_for_customer_BUS.usp_createTourForm_svs(cusTour);
            if (res != 0)
            {
                MessageBox.Show("Book successfully!");
            }
            else
            {
                MessageBox.Show("Book failed. Please try again");
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbPhone.Text.Length == 11)
            {
                cus = Services_for_customer_BUS.usp_getCustomerByPhone(tbPhone.Text);
                tbRegister.Text = cus.Name;

            }
        }
    }
}
