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

namespace GUI_HotelManagement
{
    public partial class MultiRoom_Form : Form
    {
        public MultiRoom_Form()
        {
            InitializeComponent();
            bookingRoom_DataGrid.Columns.Add("NameRoom", "Name");
            bookingRoom_DataGrid.Columns.Add("PriceRoom", "Price");
            bookingRoom_DataGrid.Columns.Add("TypeRoom", "Type");

            setData_FilterType();
        }
        void setData_FilterType()
        {
            List<string> ListRoomName = Room_BUS.getListRoom_Type("Trống", "All");
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
            roundedButton.Click += Show_Click;
            ListRoom_FlowLayout.Controls.Add(roundedButton);
        }

        List<Button> buttonList = new List<Button>();
        private void Show_Click(object sender, EventArgs e)
        {
            string roomname = (sender as Button).Text.Split('\n')[0];
            string price = Room_BUS.getRoomPrice(new Room_DTO(roomname));
            string type = (sender as Button).Text.Split('\n')[1];
            //Thêm vào DataGrid
            if ((sender as Button).BackColor == Color.FromArgb(0, 193, 138))
            {
                Button disableButton = sender as Button;
                bookingRoom_DataGrid.Rows.Add(roomname, price, type);
                buttonList.Add(sender as Button);
                //(sender as Button).Enabled = false;
                (sender as Button).BackColor = Color.Gray;
            }
            else if ((sender as Button).BackColor == Color.Gray)
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa phòng ra khỏi danh sách đặt ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in bookingRoom_DataGrid.Rows)
                    {
                        if (row.Cells["NameRoom"].Value.ToString() == roomname && !row.IsNewRow)
                        {
                            bookingRoom_DataGrid.Rows.Remove(row);
                            (sender as Button).BackColor = Color.FromArgb(0, 193, 138);
                        }
                    }
                }
                else
                {
                    return;
                }
            }

            //Ẩn khỏi layoutPanel
            //ListRoom_FlowLayout.Controls.Remove(sender as Button);
        }

        private void bookingRoom_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == bookingRoom_DataGrid.Columns["NameRoom"].Index && e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = bookingRoom_DataGrid.Rows[e.RowIndex];
            //    string roomname = selectedRow.Cells["NameRoom"].Value.ToString() + '\n' + selectedRow.Cells["TypeRoom"].Value.ToString();
            //    bookingRoom_DataGrid.Rows.Remove(selectedRow);
            //    foreach (Button value in buttonList)
            //    {
            //        if (value.Text == roomname) { value.Enabled = true; value.BackColor = Color.FromArgb(0, 193, 138); break; }
            //    }
            //    createButton(roomname);
            //}
            //else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
