using BUS_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Driver.WriteConcern;
using System.Xml.Linq;

namespace GUI_HotelManagement
{
    public partial class damagedItems : Form
    {
        BookingForm_DTO infoBooking = new BookingForm_DTO("null");
        public damagedItems(BookingForm_DTO bookingInfo)
        {
            InitializeComponent();
            infoBooking = bookingInfo;
            damageList_DataGrid.Columns.Add("Name", "Name");
            damageList_DataGrid.Columns.Add("Amount", "Amount");
            damageList_DataGrid.Columns.Add("Price", "Price");
            damageList_DataGrid.Columns.Add("Total_Price", "Total_Price");
            setData();

        }
        public damagedItems(BookingForm_DTO bookingInfo, DataTable damageList)
        {
            InitializeComponent();
            infoBooking = bookingInfo;
            damageList_DataGrid.Columns.Add("Name", "Name");
            damageList_DataGrid.Columns.Add("Amount", "Amount");
            damageList_DataGrid.Columns.Add("Price", "Price");
            damageList_DataGrid.Columns.Add("Total_Price", "Total_Price");
            foreach (DataRow row in damageList.Rows)
            {
                damageList_DataGrid.Rows.Add(row["Name"], row["Amount"], row["Price"], row["Total_Price"]);
            }
            foreach (DataGridViewRow row in damageList_DataGrid.Rows)
            {
                if (!row.IsNewRow && row.Cells["Total_Price"].Value.ToString() == "")
                {
                    damageList_DataGrid.Rows.Remove(damageList_DataGrid.Rows[row.Index]);
                }
            }
            setData();

        }
        void setData()
        {
            List<string> ListRoomName = BookingForm_BUS.getListRoomOfBooking(infoBooking);
            foreach (string roomName in ListRoomName)
            {
                createButton(roomName);
            }
        }
        public void createButton(string roomName)
        {
            Button roundedButton = new Button();
            roundedButton.Text = roomName;
            roundedButton.Font = new Font(roundedButton.Font.FontFamily, 12, roundedButton.Font.Style);
            string statusRoom = Room_BUS.getRoomStatus(new Room_DTO(roomName.Split('\n')[0]));
            if (statusRoom == null) { return; }
            else if (statusRoom == "Trống")
            {
                roundedButton.BackColor = Color.FromArgb(0, 193, 138);
                roundedButton.Size = new Size(135, 103);
            }
            else if (statusRoom == "Đang sử dụng")
            {
                roundedButton.BackColor = ColorTranslator.FromHtml("#EF3B2C"); ;
                roundedButton.Size = new Size(135, 103);
            }
            else if (statusRoom == "Được đặt trước")
            {
                roundedButton.BackColor = Color.FromArgb(44, 121, 195);
                roundedButton.Size = new Size(135, 103);
            }
            roundedButton.FlatStyle = FlatStyle.Flat;
            roundedButton.FlatAppearance.BorderSize = 0;
            roundedButton.Cursor = Cursors.Hand;
            roundedButton.Click += room_Click;
            ListRoom_Layout.Controls.Add(roundedButton);
        }

        private void room_Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor != Color.Gray)
            {
                foreach (Button bt in ListRoom_Layout.Controls)
                {
                    if (bt.Text != (sender as Button).Text)
                    {
                        string statusRoom = Room_BUS.getRoomStatus(new Room_DTO(bt.Text.Split('\n')[0]));
                        if (statusRoom == null) { return; }
                        else if (statusRoom == "Trống")
                        {
                            bt.BackColor = Color.FromArgb(0, 193, 138);
                            bt.Size = new Size(135, 103);
                        }
                        else if (statusRoom == "Đang sử dụng")
                        {
                            bt.BackColor = ColorTranslator.FromHtml("#EF3B2C"); ;
                            bt.Size = new Size(135, 103);
                        }
                        else if (statusRoom == "Được đặt trước")
                        {
                            bt.BackColor = Color.FromArgb(44, 121, 195);
                            bt.Size = new Size(135, 103);
                        }
                    }
                }
                Room_DTO roomInfo = new Room_DTO((sender as Button).Text.ToString());
                items_ComboBox.DataSource = Room_BUS.getListItems(roomInfo);
                items_ComboBox.Enabled = true;
                amount_Text.Enabled = true;
                amount_Text.Text = "";
                (sender as Button).BackColor = Color.Gray;
            }
            else
            {
                string statusRoom = Room_BUS.getRoomStatus(new Room_DTO((sender as Button).Text.Split('\n')[0]));
                if (statusRoom == null) { return; }
                else if (statusRoom == "Trống")
                {
                    (sender as Button).BackColor = Color.FromArgb(0, 193, 138);
                    (sender as Button).Size = new Size(135, 103);
                }
                else if (statusRoom == "Đang sử dụng")
                {
                    (sender as Button).BackColor = ColorTranslator.FromHtml("#EF3B2C"); ;
                    (sender as Button).Size = new Size(135, 103);
                }
                else if (statusRoom == "Được đặt trước")
                {
                    (sender as Button).BackColor = Color.FromArgb(44, 121, 195);
                    (sender as Button).Size = new Size(135, 103);
                }
                items_ComboBox.DataSource = null;
                items_ComboBox.Enabled = false;
                amount_Text.Text = "";
                amount_Text.Enabled = false;
                amount_Text.Text = "";
            }
        }

        DataTable getData()
        {
            DataTable damageList = new DataTable();

            // Tạo các cột trong DataTable dựa trên cột trong DataGridView
            foreach (DataGridViewColumn column in damageList_DataGrid.Columns)
            {
                damageList.Columns.Add(column.Name);
            }

            // Sao chép dữ liệu từ DataGridView vào DataTable
            foreach (DataGridViewRow row in damageList_DataGrid.Rows)
            {
                DataRow dataRow = damageList.NewRow();

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value;
                }

                damageList.Rows.Add(dataRow);
            }
            return damageList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable damageList = getData();

            Checkout_Form checkout = new Checkout_Form(infoBooking, damageList);
            this.Hide();
            checkout.ShowDialog();
            this.Close();
        }

        private void add_Button_Click_1(object sender, EventArgs e)
        {
            string name = items_ComboBox.Text;
            string amount = amount_Text.Text;
            string price = Item_BUS.getItemPrice(new Item_DTO(name));
            string total_price = (int.Parse(price) * int.Parse(amount)).ToString();

            bool flag = false;
            int index = 0;
            if (damageList_DataGrid.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in damageList_DataGrid.Rows)
                {
                    if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString() == name)
                    {
                        flag = true;
                        index = row.Index;
                        break;
                    }
                }
            }
            if (!flag)
            {
                damageList_DataGrid.Rows.Add(name, amount, price, total_price);
            }
            else
            {
                damageList_DataGrid.Rows[index].Cells["Name"].Value = name;
                damageList_DataGrid.Rows[index].Cells["Price"].Value = price;
                damageList_DataGrid.Rows[index].Cells["Amount"].Value = amount;
                damageList_DataGrid.Rows[index].Cells["Total_Price"].Value = total_price;
            }
        }
    }
}
