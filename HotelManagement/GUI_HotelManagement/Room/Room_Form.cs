using BUS_HotelManagement;
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

namespace GUI_HotelManagement
{
    public partial class Room_Form : Form
    {
        public Room_Form()
        {
            InitializeComponent();
            setData("All", "All");
        }

        void setData(string filterStatus, string filterType)
        {
            List<string> ListRoomName = Room_BUS.getListRoom(filterStatus, filterType);
            foreach (string roomName in ListRoomName)
            {
                createButton(roomName);
            }
        }
        void setData_FilterStatus(string filterStatus, string filterType)
        {
            List<string> ListRoomName = Room_BUS.getListRoom_Status(filterStatus, filterType);
            foreach (string roomName in ListRoomName)
            {
                createButton(roomName);
            }
        }
        void setData_FilterType(string filterStatus, string filterType)
        {
            List<string> ListRoomName = Room_BUS.getListRoom_Type(filterStatus, filterType);
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
        private void Show_Click(object sender, EventArgs e)
        {
            string roomname = (sender as Button).Text.Split('\n')[0];
            showDetailRoom(roomname);
        }
        void showDetailRoom(string roomname)
        {
            Room_DTO roomName = new Room_DTO(roomname);
            DetailRoom_Form detail = new DetailRoom_Form(roomName);
            detail.ShowDialog();
        }

        public void setComboBox(string filterdValue, string filterStatus, string filterType)
        {
            ListRoom_FlowLayout.Controls.Clear();
            if (filterdValue == "All")
            {
                Filter_ComboBox.Text = filterdValue;
                setData(filterStatus, filterType);
            }
            else if (filterdValue == "Status")
            {
                Filter_ComboBox.Text = filterdValue;
                setData_FilterStatus(filterStatus, filterType);
            }
            else if (filterdValue == "Type")
            {
                Filter_ComboBox.Text = filterdValue;
                setData_FilterType(filterStatus, filterType);
            }

        }

        private void Filter_ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = Filter_ComboBox.SelectedItem.ToString();
            string selectedStatus = Status_ComboBox.SelectedItem.ToString();
            string selectedType = Type_ComboBox.SelectedItem.ToString();
            setComboBox(selectedValue, selectedStatus, selectedType);
        }

        private void Status_ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = Filter_ComboBox.SelectedItem.ToString();
            string selectedStatus = Status_ComboBox.SelectedItem.ToString();
            string selectedType = Type_ComboBox.SelectedItem.ToString();
            setComboBox(selectedValue, selectedStatus, selectedType);
        }

        private void Type_ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = Filter_ComboBox.SelectedItem.ToString();
            string selectedStatus = Status_ComboBox.SelectedItem.ToString();
            string selectedType = Type_ComboBox.SelectedItem.ToString();
            setComboBox(selectedValue, selectedStatus, selectedType);
        }
    }
}
