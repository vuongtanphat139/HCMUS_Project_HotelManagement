namespace GUI_HotelManagement
{
    partial class checkoutBill_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutBill_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateout_Label = new System.Windows.Forms.Label();
            this.idBill_Label = new System.Windows.Forms.Label();
            this.datePay_Label = new System.Windows.Forms.Label();
            this.days_Label = new System.Windows.Forms.Label();
            this.nameCus_Label = new System.Windows.Forms.Label();
            this.datein_Label = new System.Windows.Forms.Label();
            this.phone_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Information_Panel = new System.Windows.Forms.Panel();
            this.methods_Label = new System.Windows.Forms.Label();
            this.receptionist_Label = new System.Windows.Forms.Label();
            this.Cam = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Information_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách sạn HCMUS - Nhóm 7";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ : Quận 2, Trần Duy Hưng, 500k 1 đêm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotline : 0843678755";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hóa đơn khách sạn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateout_Label
            // 
            this.dateout_Label.AutoSize = true;
            this.dateout_Label.Location = new System.Drawing.Point(346, 20);
            this.dateout_Label.Name = "dateout_Label";
            this.dateout_Label.Size = new System.Drawing.Size(61, 20);
            this.dateout_Label.TabIndex = 4;
            this.dateout_Label.Text = "Ngày đi";
            this.dateout_Label.Click += new System.EventHandler(this.label5_Click);
            // 
            // idBill_Label
            // 
            this.idBill_Label.AutoSize = true;
            this.idBill_Label.Location = new System.Drawing.Point(475, 175);
            this.idBill_Label.Name = "idBill_Label";
            this.idBill_Label.Size = new System.Drawing.Size(89, 20);
            this.idBill_Label.TabIndex = 5;
            this.idBill_Label.Text = "Mã hóa đơn";
            this.idBill_Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // datePay_Label
            // 
            this.datePay_Label.AutoSize = true;
            this.datePay_Label.Location = new System.Drawing.Point(50, 175);
            this.datePay_Label.Name = "datePay_Label";
            this.datePay_Label.Size = new System.Drawing.Size(119, 20);
            this.datePay_Label.TabIndex = 6;
            this.datePay_Label.Text = "Ngày thanh toán";
            this.datePay_Label.Click += new System.EventHandler(this.label7_Click);
            // 
            // days_Label
            // 
            this.days_Label.AutoSize = true;
            this.days_Label.Location = new System.Drawing.Point(347, 40);
            this.days_Label.Name = "days_Label";
            this.days_Label.Size = new System.Drawing.Size(60, 20);
            this.days_Label.TabIndex = 7;
            this.days_Label.Text = "Số đêm";
            this.days_Label.Click += new System.EventHandler(this.label8_Click);
            // 
            // nameCus_Label
            // 
            this.nameCus_Label.AutoSize = true;
            this.nameCus_Label.Location = new System.Drawing.Point(3, 0);
            this.nameCus_Label.Name = "nameCus_Label";
            this.nameCus_Label.Size = new System.Drawing.Size(111, 20);
            this.nameCus_Label.TabIndex = 8;
            this.nameCus_Label.Text = "Tên khách hàng";
            this.nameCus_Label.Click += new System.EventHandler(this.label9_Click);
            // 
            // datein_Label
            // 
            this.datein_Label.AutoSize = true;
            this.datein_Label.Location = new System.Drawing.Point(346, 0);
            this.datein_Label.Name = "datein_Label";
            this.datein_Label.Size = new System.Drawing.Size(73, 20);
            this.datein_Label.TabIndex = 9;
            this.datein_Label.Text = "Ngày đến";
            this.datein_Label.Click += new System.EventHandler(this.label10_Click);
            // 
            // phone_Label
            // 
            this.phone_Label.AutoSize = true;
            this.phone_Label.Location = new System.Drawing.Point(3, 20);
            this.phone_Label.Name = "phone_Label";
            this.phone_Label.Size = new System.Drawing.Size(105, 20);
            this.phone_Label.TabIndex = 10;
            this.phone_Label.Text = "Phone number";
            this.phone_Label.Click += new System.EventHandler(this.label11_Click);
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Location = new System.Drawing.Point(3, 40);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(46, 20);
            this.email_Label.TabIndex = 11;
            this.email_Label.Text = "Email";
            this.email_Label.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 120);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(349, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Website : abc.xyz";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Information_Panel
            // 
            this.Information_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information_Panel.Controls.Add(this.methods_Label);
            this.Information_Panel.Controls.Add(this.receptionist_Label);
            this.Information_Panel.Controls.Add(this.email_Label);
            this.Information_Panel.Controls.Add(this.phone_Label);
            this.Information_Panel.Controls.Add(this.datein_Label);
            this.Information_Panel.Controls.Add(this.days_Label);
            this.Information_Panel.Controls.Add(this.nameCus_Label);
            this.Information_Panel.Controls.Add(this.dateout_Label);
            this.Information_Panel.Location = new System.Drawing.Point(50, 208);
            this.Information_Panel.Name = "Information_Panel";
            this.Information_Panel.Size = new System.Drawing.Size(658, 117);
            this.Information_Panel.TabIndex = 15;
            this.Information_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // methods_Label
            // 
            this.methods_Label.AutoSize = true;
            this.methods_Label.Location = new System.Drawing.Point(347, 82);
            this.methods_Label.Name = "methods_Label";
            this.methods_Label.Size = new System.Drawing.Size(168, 20);
            this.methods_Label.TabIndex = 13;
            this.methods_Label.Text = "Phương thức thanh toán";
            this.methods_Label.Click += new System.EventHandler(this.label15_Click);
            // 
            // receptionist_Label
            // 
            this.receptionist_Label.AutoSize = true;
            this.receptionist_Label.Location = new System.Drawing.Point(3, 82);
            this.receptionist_Label.Name = "receptionist_Label";
            this.receptionist_Label.Size = new System.Drawing.Size(145, 20);
            this.receptionist_Label.TabIndex = 12;
            this.receptionist_Label.Text = "Thu ngân thanh toán";
            this.receptionist_Label.Click += new System.EventHandler(this.label14_Click);
            // 
            // Cam
            // 
            this.Cam.AutoSize = true;
            this.Cam.Location = new System.Drawing.Point(238, 795);
            this.Cam.Name = "Cam";
            this.Cam.Size = new System.Drawing.Size(352, 20);
            this.Cam.TabIndex = 16;
            this.Cam.Text = "Cảm ơn quý khách đã sử dụng dịch vụ của chúng tôi";
            this.Cam.Click += new System.EventHandler(this.Cam_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 812);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(94, 29);
            this.Back_Button.TabIndex = 17;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // checkoutBill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 853);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Cam);
            this.Controls.Add(this.Information_Panel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBill_Label);
            this.Controls.Add(this.datePay_Label);
            this.Controls.Add(this.label1);
            this.Name = "checkoutBill_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bill";
            this.Load += new System.EventHandler(this.checkoutBill_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Information_Panel.ResumeLayout(false);
            this.Information_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label dateout_Label;
        private Label idBill_Label;
        private Label datePay_Label;
        private Label days_Label;
        private Label nameCus_Label;
        private Label datein_Label;
        private Label phone_Label;
        private Label email_Label;
        private PictureBox pictureBox1;
        private Label label13;
        private Panel Information_Panel;
        private Label methods_Label;
        private Label receptionist_Label;
        private Label Cam;
        private Button Back_Button;
    }
}