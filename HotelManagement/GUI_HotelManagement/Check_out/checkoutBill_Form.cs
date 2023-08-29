using BUS_HotelManagement;
using DTO_HoTelManagement;
using GUI_HotelManagement.Check_out;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace GUI_HotelManagement
{
    public partial class checkoutBill_Form : Form
    {
        class roomInfo
        {
            public string name { get; set; }
            public int price { get; set; }
            public int amount { get; set; }
        }
        DataTable _roomList = new DataTable();
        DataTable _serviceList = new DataTable();
        DataTable _damagedList = new DataTable();
        List<roomInfo> roomInfoList = new List<roomInfo>();

        int subtotal_room;
        int subtotal_item;
        int subtotal_service;

        string billID = "";

        public checkoutBill_Form(string idBill, BookingForm_DTO billBooking, Customer_DTO cusInfo, DataTable roomList, DataTable serviceList, DataTable damagedList)
        {
            InitializeComponent();

            datePay_Label.Text = "Ngày thanh toán : " + DateTime.Today.ToString();
            idBill_Label.Text = "Mã hóa đơn : " + idBill;
            billID = idBill;
            nameCus_Label.Text = "Tên khách hàng : " + cusInfo.Name;

            string cusInformation = Customer_BUS.getCusInfo(cusInfo);
            phone_Label.Text = "NO.Phone : " + cusInformation.Split('\n')[0];
            email_Label.Text = "Email : " + cusInformation.Split('\n')[1];

            datein_Label.Text = "Ngày đến : " + BookingForm_BUS.getIn_Date(billBooking).ToString();
            dateout_Label.Text = "Ngày đi : " + BookingForm_BUS.getOut_Date(billBooking).ToString();

            TimeSpan diff = BookingForm_BUS.getIn_Date(billBooking) - BookingForm_BUS.getOut_Date(billBooking);
            int daysDifference = Math.Abs((int)diff.TotalDays);
            days_Label.Text = "Số đêm : " + daysDifference.ToString();

            //update dataprovider rồi sửa lại
            receptionist_Label.Text = "Thu ngân thanh toán : " + "Phúc Ngô";

            methods_Label.Text = "Phương thức thanh toán" + BookingForm_BUS.getPaymenMethods(billBooking);

            _roomList = roomList;
            _serviceList = serviceList;
            _damagedList = damagedList;

            //Name
            Label _name = new Label();
            _name.Location = new Point(Information_Panel.Location.X + 20, Information_Panel.Location.Y + 65);
            _name.Text = "Name";
            Controls.Add(_name);
            //Price
            Label _price = new Label();
            _price.Location = new Point(Information_Panel.Location.X + 245, Information_Panel.Location.Y + 65);
            _price.Text = "Price";
            Controls.Add(_price);
            //Amount
            Label _amount = new Label();
            _amount.Location = new Point(Information_Panel.Location.X + 370, Information_Panel.Location.Y + 65);
            _amount.Text = "Amount";
            Controls.Add(_amount);
            //Total_Price
            Label _total_price = new Label();
            _total_price.Location = new Point(Information_Panel.Location.X+ 500, Information_Panel.Location.Y + 65);
            _total_price.Text = "Total price";
            Controls.Add(_total_price);

            Label firstLine = createLine();
            firstLine.Location = new Point(Information_Panel.Location.X, Information_Panel.Location.Y+75);
            Controls.Add(firstLine);

            Label roomFee = new Label();
            roomFee.Location = new Point(this.Size.Width / 16, firstLine.Location.Y + 25);
            roomFee.AutoSize = true;
            roomFee.Text = "Room Fee";
            Controls.Add(roomFee);
            setRoomDetails(firstLine);

            Label secondLine = createLine();
            secondLine.Location = new Point(firstLine.Location.X, firstLine.Location.Y + 30*5 + 25);
            Controls.Add(secondLine);

            setServiceTotal(secondLine);

            Label thirdLine = new Label();
            thirdLine = createLine();
            thirdLine.Location = new Point(firstLine.Location.X, firstLine.Location.Y + 30 * 7 + 25);
            Controls.Add(thirdLine);
            setDamagedTotal(thirdLine);

            Label fourLine = new Label();
            fourLine = createLine();
            fourLine.Location = new Point(firstLine.Location.X, firstLine.Location.Y + 30 * 9 + 25);
            Controls.Add(fourLine);

            Label subtotal_Price = new Label();
            subtotal_Price.Location = new Point(this.Size.Width / 8 * 4 + 220, fourLine.Location.Y + 30);
            subtotal_Price.AutoSize = true;
            subtotal_Price.Text = (subtotal_item + subtotal_room + subtotal_service).ToString();
            Controls.Add(subtotal_Price);



        }
        Label createLine()
        {
            Label line = new Label();
            line.AutoSize = true;
            //MessageBox.Show((this.Size.Width / 16).ToString() + "   -    " + (this.Size.Width / 8 * 4).ToString());
            for(int i= 0; i < 114; i++)
            {
                line.Text += '_';
            }
            
            return line;
        }
        void setRoomDetails(Label roomInfo_Label)
        {
            int amount = 0;
            int _total_price = 0;
            foreach (DataRow dr in _roomList.Rows)
            {
                string name = dr["TYPE"].ToString();
                bool exists = false;

                // Kiểm tra xem name đã tồn tại trong roomInfoList hay chưa
                foreach (roomInfo r in roomInfoList)
                {
                    if (r.name == name)
                    {
                        exists = true;
                        r.amount += 1;
                        break;
                    }
                }

                // Nếu name chưa tồn tại trong roomInfoList, thêm mới vào danh sách
                if (!exists)
                {
                    roomInfo _r = new roomInfo();
                    _r.name = name;
                    _r.price = int.Parse(dr["PRICE"].ToString());
                    _r.amount = 1;
                    roomInfoList.Add(_r);
                }
            }
            int distance = 1;
            foreach(roomInfo showRoom in roomInfoList)
            {
                
                //Label roomname
                Label roomName = new Label();
                roomName.Location = new Point(this.Size.Width/16, roomInfo_Label.Location.Y + 30*distance + 25);
                roomName.AutoSize = true;
                roomName.Text = "(+)" + showRoom.name;
                Controls.Add(roomName);
                //label priceroom
                Label roomPrice = new Label();
                roomPrice.Location = new Point(this.Size.Width / 8*2 + 120, roomInfo_Label.Location.Y + 30 * distance + 25);
                roomPrice.AutoSize = true;
                roomPrice.Text = showRoom.price.ToString();
                Controls.Add(roomPrice);
                //label amountRoom
                Label amountRoom = new Label();
                amountRoom.Location = new Point(this.Size.Width / 8*3 + 180, roomInfo_Label.Location.Y + 30 * distance + 25 );
                amountRoom.AutoSize = true;
                amountRoom.Text = showRoom.amount.ToString();
                Controls.Add(amountRoom);
                //label total_price
                Label total_price = new Label();
                total_price.Location = new Point(this.Size.Width / 8*4 + 220, roomInfo_Label.Location.Y + 30 * distance + 25);
                total_price.AutoSize = true;
                total_price.Text = (showRoom.price * showRoom.amount).ToString();
                Controls.Add(total_price);

                _total_price += (showRoom.price * showRoom.amount);
                distance++;
            }
            //label total_price Room Fee
            Label roomFee = new Label();
            roomFee.Location = new Point(this.Size.Width / 8 * 4 + 220, roomInfo_Label.Location.Y + 25);
            roomFee.AutoSize = true;
            roomFee.Text = _total_price.ToString();
            Controls.Add(roomFee);
            subtotal_room = _total_price;
        }

        void setServiceTotal(Label secondLine)
        {
            int total_price = 0;
            if(_serviceList.Rows.Count > 0)
            {
                foreach (DataRow dr in _serviceList.Rows)
                {
                    string price = dr["TOTAL_PRICE"].ToString();
                    total_price += int.Parse(price);
                }
            }
            //label Service Label
            Label Service = new Label();
            Service.Location = new Point(this.Size.Width / 16, secondLine.Location.Y + 30);
            Service.AutoSize = true;
            Service.Text = "Service Fee";
            Controls.Add(Service);
            //label total_price
            Label service_total_price = new Label();
            service_total_price.Location = new Point(this.Size.Width / 8 * 4 + 220, secondLine.Location.Y + 30);
            service_total_price.AutoSize = true;
            service_total_price.Text = total_price.ToString();
            Controls.Add(service_total_price);
            subtotal_service = total_price;
        }
        void setDamagedTotal(Label thirdLine)
        {
            int total_price = 0;
            
            if (_damagedList.Rows.Count > 0)
            {
                foreach (DataRow dr in _damagedList.Rows)
                {
                    if (dr["TOTAL_PRICE"].ToString() != "")
                    {
                        string price = dr["Total_Price"].ToString();
                        total_price += int.Parse(price);
                    }  
                }
                
            }
            Label Items = new Label();
            Items.Location = new Point(this.Size.Width / 16, thirdLine.Location.Y + 30);
            Items.AutoSize = true;
            Items.Text = "Damaged Items Fee";
            Controls.Add(Items);

            Label items_total_price = new Label();
            items_total_price.Location = new Point(this.Size.Width / 8 * 4 + 220, thirdLine.Location.Y + 30);
            items_total_price.AutoSize = true;
            items_total_price.Text = total_price.ToString();
            Controls.Add(items_total_price);
            subtotal_item = total_price;

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkoutBill_Form_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cam_Click(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want feedback about our service ?", "Feedback", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Feedback fd = new Feedback(billID);
                fd.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
