using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using BUS_HotelManagement;
using DTO_HoTelManagement;
using DTO_HoTelManagement;
using GUI_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class Check_inForm : Form
    {
        public Check_inForm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string BookingId = BookID_Text.Text.ToString();
            BookingForm_DTO IdBooking = new BookingForm_DTO(BookingId);

            string guestName = BookingForm_BUS.getGuestName(IdBooking);
            string cusIDBK = Customer_BUS.getCusID_Checkin(new Customer_DTO(Name_Text.Text));
            bool flag = BookingForm_BUS.check_Booking(IdBooking);
            if (BookID_Text.Text != "" && Name_Text.Text == "" && flag)
            {
                Booking_Grid.DataSource = BookingForm_BUS.LoadData(IdBooking);
                Name_Text.Text = BookingForm_BUS.getGuestName(IdBooking);
                NoRooms_Text.Text = BookingForm_BUS.getNumberofrooms(IdBooking);
                IdentityNo_Text.Text = BookingForm_BUS.getNoIdentity(IdBooking);
                SPRequiments_Text.Text = BookingForm_BUS.getSPRequires(IdBooking);
                Price_Text.Text = BookingForm_BUS.getPrice(IdBooking);
                Edit_Button.Enabled = true;
                In_Datatime.Value = BookingForm_BUS.getIn_Date(IdBooking);
                Out_Datetime.Value = BookingForm_BUS.getOut_Date(IdBooking);
                Own_CheckList.Enabled = true;
                Agent_CheckBox.Enabled = true;
                string cusSupply = Supply_Form_BUS.getRegisterName(new Supply_Form_DTO(Name_Text.Text));
                if (cusSupply != null)
                {
                    group_CheckBox.Checked = true;
                    gName_Text.Text = cusSupply.Split('\n')[0];
                    amountGroup_Text.Text = cusSupply.Split('\n')[1];
                }
            }
            else if (BookID_Text.Text == "" && Name_Text.Text != "")
            {
                bool flagCus = BookingForm_BUS.check_Booking(new BookingForm_DTO(cusIDBK));
                if (flagCus)
                {
                    Booking_Grid.DataSource = BookingForm_BUS.LoadData(new BookingForm_DTO(cusIDBK));
                    Name_Text.Text = BookingForm_BUS.getGuestName(new BookingForm_DTO(cusIDBK));
                    NoRooms_Text.Text = BookingForm_BUS.getNumberofrooms(new BookingForm_DTO(cusIDBK));
                    IdentityNo_Text.Text = BookingForm_BUS.getNoIdentity(new BookingForm_DTO(cusIDBK));
                    SPRequiments_Text.Text = BookingForm_BUS.getSPRequires(new BookingForm_DTO(cusIDBK));
                    Price_Text.Text = BookingForm_BUS.getPrice(new BookingForm_DTO(cusIDBK));
                    Edit_Button.Enabled = true;
                    In_Datatime.Value = BookingForm_BUS.getIn_Date(new BookingForm_DTO(cusIDBK));
                    Out_Datetime.Value = BookingForm_BUS.getOut_Date(new BookingForm_DTO(cusIDBK));
                    Own_CheckList.Enabled = true;
                    Agent_CheckBox.Enabled = true;
                    string cusSupply = Supply_Form_BUS.getRegisterName(new Supply_Form_DTO(Name_Text.Text));
                    if (cusSupply != null)
                    {
                        group_CheckBox.Checked = true;
                        gName_Text.Text = cusSupply.Split('\n')[0];
                        amountGroup_Text.Text = cusSupply.Split('\n')[1];
                    }
                }
                else
                {
                    showMessage();
                }
            }
            else if (BookID_Text.Text != "" && Name_Text.Text != "")
            {
                //MessageBox.Show(cusIDBK +"-"+ BookingId + "\n" + Name_Text.Text + "-" + BookingForm_BUS.getGuestName(IdBooking));
                if(cusIDBK == BookingId)// && Name_Text.Text == BookingForm_BUS.getGuestName(IdBooking))
                {
                    Booking_Grid.DataSource = BookingForm_BUS.LoadData(IdBooking);
                    Name_Text.Text = BookingForm_BUS.getGuestName(IdBooking);
                    NoRooms_Text.Text = BookingForm_BUS.getNumberofrooms(IdBooking);
                    IdentityNo_Text.Text = BookingForm_BUS.getNoIdentity(IdBooking);
                    SPRequiments_Text.Text = BookingForm_BUS.getSPRequires(IdBooking);
                    Price_Text.Text = BookingForm_BUS.getPrice(IdBooking);
                    Edit_Button.Enabled = true;
                    In_Datatime.Value = BookingForm_BUS.getIn_Date(IdBooking);
                    Out_Datetime.Value = BookingForm_BUS.getOut_Date(IdBooking);
                    Own_CheckList.Enabled = true;
                    Agent_CheckBox.Enabled = true;
                    string cusSupply = Supply_Form_BUS.getRegisterName(new Supply_Form_DTO(Name_Text.Text));
                    if (cusSupply != null)
                    {
                        group_CheckBox.Checked = true;
                        gName_Text.Text = cusSupply.Split('\n')[0];
                        amountGroup_Text.Text = cusSupply.Split('\n')[1];
                    }
                }
                else
                {
                    showMessage();
                }
            }
            else
            {
                showMessage();
            }
        }
        void showMessage()
        {
            MessageBox.Show("Không tồn tại!");
            Booking_Grid.DataSource = null;
            BookID_Text.Text = "";
            Name_Text.Text = "";
            NoRooms_Text.Text = "";
            NoRooms_Text.Text = "";
            IdentityNo_Text.Text = "";
            SPRequiments_Text.Text = "";
            Price_Text.Text = "";
            Edit_Button.Enabled = false;
            In_Datatime.Value = DateTime.Today;
            Out_Datetime.Value = DateTime.Today.AddMonths(1);
            for (int i = 0; i < Own_CheckList.Items.Count; i++)
            {
                Own_CheckList.SetItemChecked(i, false);
            }
            Own_CheckList.Enabled = false;
            Agent_CheckBox.Checked = false;
            Agent_CheckBox.Enabled = false;
            group_CheckBox.Checked = false;
            gName_Text.Text = "";
            amountGroup_Text.Text = "";
        }

        public bool isEditing = true;

<<<<<<< Updated upstream
        private void button2_Click_1(object sender, EventArgs e)
=======
        private void Search_Button_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            LoadData();
        }

<<<<<<< Updated upstream
        private void Edit_Button_Click_1(object sender, EventArgs e)
=======
        private void Refresh_Button_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            if (isEditing)
            {
                Edit_Button.Text = "Confirm";
                SPRequiments_Text.Enabled = true;
                SPRequiments_Text.ReadOnly = false;
            }
            else
            {
                Edit_Button.Text = "Edit";
                SPRequiments_Text.Enabled = false;
                SPRequiments_Text.ReadOnly = true;
            }
            isEditing = !isEditing;
        }

<<<<<<< Updated upstream
=======
        private void Agent_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Agent_CheckBox.Checked == true)
            {
                for (int i = 0; i < Own_CheckList.Items.Count; i++)
                {
                    Own_CheckList.SetItemChecked(i, false);
                }
                //Own_CheckList.Enabled = false;
            }
            //else Own_CheckList.Enabled = true;
        }

>>>>>>> Stashed changes
        private void Own_CheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = Own_CheckList.CheckedItems.Count;
            int index = Own_CheckList.SelectedIndex;

            for (int i = 0; i < Own_CheckList.Items.Count; i++)
            {
                if (i != index)
                {
                    Own_CheckList.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
<<<<<<< Updated upstream
        }

        private void Agent_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Agent_CheckBox.Checked == true)
            {
                for (int i = 0; i < Own_CheckList.Items.Count; i++)
                {
                    Own_CheckList.SetItemChecked(i, false);
                }
                Own_CheckList.Enabled = false;
            }
            else Own_CheckList.Enabled = true;
=======
            Agent_CheckBox.Checked = false;
        }

        private void Edit_Button_Click_1(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Edit_Button.Text = "Confirm";
                SPRequiments_Text.Enabled = true;
                SPRequiments_Text.ReadOnly = false;
            }
            else
            {
                Edit_Button.Text = "Edit";
                SPRequiments_Text.Enabled = false;
                SPRequiments_Text.ReadOnly = true;
            }
            isEditing = !isEditing;
>>>>>>> Stashed changes
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thông tin Check-in!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string BookingId = BookID_Text.Text.ToString();
                string SPRequiments = SPRequiments_Text.Text.ToString();
                string Pay_Methods = "NULL";
                if (BookingId == "")
                {
                    MessageBox.Show("Cập nhật thất bại, xin nhập ID_Booking");
                    return;
                }
                else if (Agent_CheckBox.Checked == true)
                {
                    Pay_Methods = Agent_CheckBox.Text.ToString();

                    BookingForm_DTO UpdateBooking = new BookingForm_DTO(BookingId, SPRequiments, Pay_Methods);
                    bool flag = BookingForm_BUS.Update_BookingForm(UpdateBooking);

                    if (flag)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.Hide();
                        NoticeCheck_inForm viewNotice = new NoticeCheck_inForm();
                        viewNotice.ShowDialog();
                    }
                }
                else if (Own_CheckList.CheckedItems.Count > 0)
                {
                    foreach (var item in Own_CheckList.CheckedItems)
                    {
                        Pay_Methods = item.ToString();
                        break;
                    }

                    BookingForm_DTO UpdateBooking = new BookingForm_DTO(BookingId, SPRequiments, Pay_Methods);
                    bool flag = BookingForm_BUS.Update_BookingForm(UpdateBooking);

                    if (flag)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.Hide();
                        NoticeCheck_inForm viewNotice = new NoticeCheck_inForm();
                        viewNotice.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại, chưa xác nhận phương thức thanh toán");
                    return;
                };
            }
            else
            {
                return;
            }
        }

<<<<<<< Updated upstream
        private void button1_Click_1(object sender, EventArgs e)
        {
            BookID_Text.Text = "";
            Booking_Grid.DataSource = null;
            Name_Text.Text = "";
            NoRooms_Text.Text = "";
            NoRooms_Text.Text = "";
            IdentityNo_Text.Text = "";
            SPRequiments_Text.Text = "";
            Price_Text.Text = "";
            Edit_Button.Enabled = false;
            In_Datatime.Value = DateTime.Today;
            Out_Datetime.Value = DateTime.Today.AddMonths(1);
            for (int i = 0; i < Own_CheckList.Items.Count; i++)
            {
                Own_CheckList.SetItemChecked(i, false);
            }
            Own_CheckList.Enabled = false;
            Agent_CheckBox.Checked = false;
            Agent_CheckBox.Enabled = false;
            group_CheckBox.Checked = false;
            gName_Text.Text = "";
            amountGroup_Text.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
=======
        private void button3_Click(object sender, EventArgs e)
        {
>>>>>>> Stashed changes
            this.Close();
        }
    }
}
