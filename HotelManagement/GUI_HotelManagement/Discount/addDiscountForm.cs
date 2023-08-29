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
using System.Xml.Linq;

namespace GUI_HotelManagement
{
    public partial class addDiscountForm : Form
    {
        bool check = true;
        DiscountPromotion_DTO Discount = new DiscountPromotion_DTO();
        public addDiscountForm()
        {
            InitializeComponent();
            check = true;
        }
        public addDiscountForm(DiscountPromotion_DTO discountID)
        {
            InitializeComponent();
            Discount = discountID;
            check = false;
            setData();

        }
        public void setData()
        {
            string DiscountInfo = DiscountPromotion_BUS.getDiscountInfo(Discount);
            nameDiscount_Text.Text = DiscountInfo.Split('\n')[0];
            Start_Date.Value = DateTime.Parse(DiscountInfo.Split('\n')[1]);
            End_Date.Value = DateTime.Parse(DiscountInfo.Split('\n')[2]);
            Descript_Text.Text = DiscountInfo.Split('\n')[3];

            for (int i = 0; i < Type_CheckList.Items.Count; i++)
            {
                if (Type_CheckList.Items[i].ToString() == DiscountInfo.Split('\n')[4])
                {
                    Type_CheckList.SetItemChecked(i, true);
                }
                else Type_CheckList.SetItemChecked(i, false);
            }
            AmountRequiment_Text.Text = DiscountInfo.Split('\n')[5];
            PercentDiscount_Text.Text = DiscountInfo.Split('\n')[6];
            if (DiscountInfo.Split('\n')[4] == "Giảm giá")
            {
                PercentDiscount_Text.Enabled = true;
                AmountRequiment_Text.Enabled = false;
            }
            else
            {
                PercentDiscount_Text.Enabled = false;
                AmountRequiment_Text.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check)
            {
                DialogResult result = MessageBox.Show("Xác nhận thêm dịch vụ!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    String name = nameDiscount_Text.Text;
                    string startDate = Start_Date.Value.ToString();
                    string endDate = End_Date.Value.ToString();
                    string descript = Descript_Text.Text;
                    string type = "NULL";

                    if (name == "" || DateTime.Compare(DateTime.Parse(startDate), DateTime.Parse(endDate)) >= 0)
                    {
                        MessageBox.Show("Thêm thất bại, tên chương trình khuyến mãi hoặc ngày diễn ra không hợp lệ");
                        return;
                    }
                    else if (Type_CheckList.CheckedItems.Count > 0)
                    {
                        foreach (var item in Type_CheckList.CheckedItems)
                        {
                            type = item.ToString();
                            break;
                        }
                        MessageBox.Show(type);
                        if (type == "Giảm giá" && PercentDiscount_Text.Text != "")
                        {
                            float percent = float.Parse(PercentDiscount_Text.Text);
                            if (percent <= 0)
                            {
                                MessageBox.Show("Phần trăm khuyến mãi không hợp lệ, xin hãy nhập lại!");
                                return;
                            }
                            DiscountPromotion_DTO discountInfo = new DiscountPromotion_DTO(name, startDate, endDate, descript, type, percent, -1);
                            bool flag = DiscountPromotion_BUS.addDiscount(discountInfo);
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
                        else if (type != "Giảm giá" && AmountRequiment_Text.Text != "")
                        {
                            int amount = int.Parse(AmountRequiment_Text.Text);
                            if (amount < 0)
                            {
                                MessageBox.Show("Số lượng yêu cầu không hợp lệ, xin hãy nhập lại!");
                                return;
                            }
                            DiscountPromotion_DTO discountInfo = new DiscountPromotion_DTO(name, startDate, endDate, descript, type, -1, amount);
                            bool flag = DiscountPromotion_BUS.addDiscount(discountInfo);
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
                            MessageBox.Show("Thêm thất bại, thông tin chưa đầy đủ!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại, chưa xác nhận hình thức khuyến mãi");
                        return;
                    };
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác nhận cập nhật chương trình!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string discountId = Discount.IdDiscount;
                    string discountName = nameDiscount_Text.Text;
                    string dateIn = Start_Date.Value.ToString();
                    string dateOut = End_Date.Value.ToString();
                    string Descript = Descript_Text.Text;
                    string typeDiscount = "";
                    foreach (var item in Type_CheckList.SelectedItems)
                    {
                        typeDiscount = item.ToString();
                        break;
                    }

                    if (typeDiscount == "Giảm giá" && PercentDiscount_Text.Text != "")
                    {
                        float percent = float.Parse(PercentDiscount_Text.Text);
                        if (percent <= 0)
                        {
                            MessageBox.Show("Phần trăm khuyến mãi không hợp lệ, xin hãy nhập lại!");
                            return;
                        }
                        DiscountPromotion_DTO discountInfo = new DiscountPromotion_DTO(discountId, discountName, dateIn, dateOut, Descript, typeDiscount, percent, -1);
                        bool flag = DiscountPromotion_BUS.updateDiscount(discountInfo);
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
                    else if (typeDiscount != "Giảm giá" && AmountRequiment_Text.Text != "")
                    {
                        int amount = int.Parse(AmountRequiment_Text.Text);
                        if (amount < 0)
                        {
                            MessageBox.Show("Số lượng yêu cầu không hợp lệ, xin hãy nhập lại!");
                            return;
                        }
                        DiscountPromotion_DTO discountInfo = new DiscountPromotion_DTO(discountId, discountName, dateIn, dateOut, Descript, typeDiscount, -1, amount);
                        bool flag = DiscountPromotion_BUS.updateDiscount(discountInfo);
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (check)
            {
                nameDiscount_Text.Text = "";
                Start_Date.Value = DateTime.Today;
                End_Date.Value = DateTime.Today.AddMonths(1);
                Descript_Text.Text = null;
                for (int i = 0; i < Type_CheckList.Items.Count; i++)
                {
                    Type_CheckList.SetItemChecked(i, false);
                }
                PercentDiscount_Text.Enabled = false;
                PercentDiscount_Text.Text = "";

                AmountRequiment_Text.Enabled = false;
                AmountRequiment_Text.Text = "";
            }
            else
            {
                setData();
            }
        }

        private void Type_CheckList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int count = Type_CheckList.CheckedItems.Count;
            int index = Type_CheckList.SelectedIndex;

            for (int i = 0; i < Type_CheckList.Items.Count; i++)
            {
                if (i != index)
                {
                    Type_CheckList.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            string _checked = "NULL";
            foreach (var item in Type_CheckList.SelectedItems)
            {
                _checked = item.ToString();
                break;
            }
            if (_checked == "Giảm giá")
            {
                PercentDiscount_Text.Enabled = true;
                AmountRequiment_Text.Enabled = false;
            }
            else
            {
                PercentDiscount_Text.Enabled = false;
                AmountRequiment_Text.Enabled = true;
            }
        }

        private void PercentDiscount_Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
