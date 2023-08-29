namespace GUI_HotelManagement
{
    partial class Checkout_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout_Form));
            this.BookingId_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBooking_Text = new System.Windows.Forms.TextBox();
            this.cusName_Text = new System.Windows.Forms.TextBox();
            this.roomFee_Text = new System.Windows.Forms.TextBox();
            this.serviceFee_Text = new System.Windows.Forms.TextBox();
            this.damageFee_Text = new System.Windows.Forms.TextBox();
            this.addDamage_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalFee_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Method_ComboBox = new System.Windows.Forms.ComboBox();
<<<<<<< Updated upstream
            this.button3 = new System.Windows.Forms.Button();
=======
            this.Refresh_Button = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listRoom_DataGrid = new System.Windows.Forms.DataGridView();
            this.listService_DataGrid = new System.Windows.Forms.DataGridView();
<<<<<<< Updated upstream
            this.button1 = new System.Windows.Forms.Button();
=======
            this.Confirm_Button = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.damage_DataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.depositPrice_Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< Updated upstream
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
=======
            this.close_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search_Button = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.listRoom_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listService_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damage_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookingId_Label
            // 
            this.BookingId_Label.AutoSize = true;
            this.BookingId_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookingId_Label.Location = new System.Drawing.Point(43, 37);
            this.BookingId_Label.Name = "BookingId_Label";
            this.BookingId_Label.Size = new System.Drawing.Size(98, 23);
            this.BookingId_Label.TabIndex = 0;
            this.BookingId_Label.Text = "Booking ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room fee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Damage fee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service fee:";
            // 
            // idBooking_Text
            // 
            this.idBooking_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBooking_Text.Enabled = false;
            this.idBooking_Text.Location = new System.Drawing.Point(186, 32);
            this.idBooking_Text.Name = "idBooking_Text";
<<<<<<< Updated upstream
=======
            this.idBooking_Text.ReadOnly = true;
>>>>>>> Stashed changes
            this.idBooking_Text.Size = new System.Drawing.Size(292, 27);
            this.idBooking_Text.TabIndex = 5;
            // 
            // cusName_Text
            // 
            this.cusName_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusName_Text.Location = new System.Drawing.Point(186, 73);
            this.cusName_Text.Name = "cusName_Text";
            this.cusName_Text.Size = new System.Drawing.Size(292, 27);
            this.cusName_Text.TabIndex = 6;
            // 
            // roomFee_Text
            // 
            this.roomFee_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomFee_Text.Enabled = false;
            this.roomFee_Text.Location = new System.Drawing.Point(186, 115);
            this.roomFee_Text.Name = "roomFee_Text";
            this.roomFee_Text.Size = new System.Drawing.Size(178, 27);
            this.roomFee_Text.TabIndex = 7;
            // 
            // serviceFee_Text
            // 
            this.serviceFee_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceFee_Text.Enabled = false;
            this.serviceFee_Text.Location = new System.Drawing.Point(186, 157);
            this.serviceFee_Text.Name = "serviceFee_Text";
            this.serviceFee_Text.Size = new System.Drawing.Size(178, 27);
            this.serviceFee_Text.TabIndex = 8;
            // 
            // damageFee_Text
            // 
            this.damageFee_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.damageFee_Text.Enabled = false;
            this.damageFee_Text.Location = new System.Drawing.Point(186, 241);
            this.damageFee_Text.Name = "damageFee_Text";
            this.damageFee_Text.Size = new System.Drawing.Size(178, 27);
            this.damageFee_Text.TabIndex = 9;
            // 
            // addDamage_Button
            // 
            this.addDamage_Button.BackColor = System.Drawing.Color.White;
            this.addDamage_Button.Enabled = false;
            this.addDamage_Button.FlatAppearance.BorderSize = 0;
            this.addDamage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDamage_Button.Image = ((System.Drawing.Image)(resources.GetObject("addDamage_Button.Image")));
            this.addDamage_Button.Location = new System.Drawing.Point(382, 239);
            this.addDamage_Button.Name = "addDamage_Button";
            this.addDamage_Button.Size = new System.Drawing.Size(31, 35);
            this.addDamage_Button.TabIndex = 10;
            this.addDamage_Button.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
            this.addDamage_Button.Click += new System.EventHandler(this.addDamage_Button_Click_1);
=======
>>>>>>> Stashed changes
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total fee:";
            // 
            // totalFee_Text
            // 
            this.totalFee_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFee_Text.Enabled = false;
            this.totalFee_Text.Location = new System.Drawing.Point(186, 284);
            this.totalFee_Text.Name = "totalFee_Text";
            this.totalFee_Text.Size = new System.Drawing.Size(178, 27);
            this.totalFee_Text.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(42, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Payment method:";
            // 
            // Method_ComboBox
            // 
            this.Method_ComboBox.FormattingEnabled = true;
            this.Method_ComboBox.Items.AddRange(new object[] {
            "None",
            "Cash",
            "Credit Card",
            "Traveller Cheque",
            "Travel agent account"});
            this.Method_ComboBox.Location = new System.Drawing.Point(186, 327);
            this.Method_ComboBox.Name = "Method_ComboBox";
            this.Method_ComboBox.Size = new System.Drawing.Size(292, 28);
            this.Method_ComboBox.TabIndex = 15;
            // 
            // Refresh_Button
            // 
<<<<<<< Updated upstream
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button3.Location = new System.Drawing.Point(449, 800);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 67);
            this.button3.TabIndex = 16;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
=======
            this.Refresh_Button.FlatAppearance.BorderSize = 2;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Refresh_Button.Location = new System.Drawing.Point(449, 800);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(208, 67);
            this.Refresh_Button.TabIndex = 16;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
>>>>>>> Stashed changes
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(749, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "List rooms:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(1061, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "List services:";
            // 
            // listRoom_DataGrid
            // 
            this.listRoom_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRoom_DataGrid.Location = new System.Drawing.Point(749, 148);
            this.listRoom_DataGrid.Name = "listRoom_DataGrid";
            this.listRoom_DataGrid.RowHeadersWidth = 51;
            this.listRoom_DataGrid.RowTemplate.Height = 29;
            this.listRoom_DataGrid.Size = new System.Drawing.Size(269, 348);
            this.listRoom_DataGrid.TabIndex = 19;
            // 
            // listService_DataGrid
            // 
            this.listService_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listService_DataGrid.Location = new System.Drawing.Point(1061, 148);
            this.listService_DataGrid.Name = "listService_DataGrid";
            this.listService_DataGrid.RowHeadersWidth = 51;
            this.listService_DataGrid.RowTemplate.Height = 29;
            this.listService_DataGrid.Size = new System.Drawing.Size(270, 348);
            this.listService_DataGrid.TabIndex = 20;
            // 
            // Confirm_Button
            // 
<<<<<<< Updated upstream
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(744, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 67);
            this.button1.TabIndex = 21;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
=======
            this.Confirm_Button.FlatAppearance.BorderSize = 2;
            this.Confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Confirm_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.Confirm_Button.Location = new System.Drawing.Point(744, 800);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(208, 67);
            this.Confirm_Button.TabIndex = 21;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
>>>>>>> Stashed changes
            // 
            // damage_DataGrid
            // 
            this.damage_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damage_DataGrid.Location = new System.Drawing.Point(30, 560);
            this.damage_DataGrid.Name = "damage_DataGrid";
            this.damage_DataGrid.RowHeadersWidth = 51;
            this.damage_DataGrid.RowTemplate.Height = 29;
            this.damage_DataGrid.Size = new System.Drawing.Size(1301, 201);
            this.damage_DataGrid.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(30, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "List damaged item:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(42, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Deposit fee:";
            // 
            // depositPrice_Text
            // 
            this.depositPrice_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositPrice_Text.Enabled = false;
            this.depositPrice_Text.Location = new System.Drawing.Point(186, 200);
            this.depositPrice_Text.Name = "depositPrice_Text";
            this.depositPrice_Text.ReadOnly = true;
            this.depositPrice_Text.Size = new System.Drawing.Size(178, 27);
            this.depositPrice_Text.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(497, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(351, 37);
            this.label11.TabIndex = 91;
            this.label11.Text = "CHECK-OUT INFOMATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.panel1.Controls.Add(this.button2);
=======
            this.panel1.Controls.Add(this.close_Button);
>>>>>>> Stashed changes
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listRoom_DataGrid);
            this.panel1.Controls.Add(this.listService_DataGrid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.damage_DataGrid);
<<<<<<< Updated upstream
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
=======
            this.panel1.Controls.Add(this.Refresh_Button);
            this.panel1.Controls.Add(this.Confirm_Button);
>>>>>>> Stashed changes
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 907);
            this.panel1.TabIndex = 92;
            // 
<<<<<<< Updated upstream
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.button2.Location = new System.Drawing.Point(1310, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 48);
            this.button2.TabIndex = 94;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
=======
            // close_Button
            // 
            this.close_Button.FlatAppearance.BorderSize = 0;
            this.close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.close_Button.Location = new System.Drawing.Point(1310, 4);
            this.close_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(46, 48);
            this.close_Button.TabIndex = 94;
            this.close_Button.Text = "x";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
>>>>>>> Stashed changes
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
<<<<<<< Updated upstream
            this.panel2.Controls.Add(this.button4);
=======
            this.panel2.Controls.Add(this.Search_Button);
>>>>>>> Stashed changes
            this.panel2.Controls.Add(this.cusName_Text);
            this.panel2.Controls.Add(this.roomFee_Text);
            this.panel2.Controls.Add(this.serviceFee_Text);
            this.panel2.Controls.Add(this.idBooking_Text);
            this.panel2.Controls.Add(this.depositPrice_Text);
            this.panel2.Controls.Add(this.damageFee_Text);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.addDamage_Button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Method_ComboBox);
            this.panel2.Controls.Add(this.BookingId_Label);
            this.panel2.Controls.Add(this.totalFee_Text);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(30, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 385);
            this.panel2.TabIndex = 92;
            // 
<<<<<<< Updated upstream
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(498, 73);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 33);
            this.button4.TabIndex = 93;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
=======
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.FlatAppearance.BorderSize = 0;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.Location = new System.Drawing.Point(484, 73);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(129, 29);
            this.Search_Button.TabIndex = 93;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
>>>>>>> Stashed changes
            // 
            // Checkout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1382, 933);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout_Form";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout_Form";
            ((System.ComponentModel.ISupportInitialize)(this.listRoom_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listService_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damage_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label BookingId_Label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idBooking_Text;
        private TextBox cusName_Text;
        private TextBox roomFee_Text;
        private TextBox serviceFee_Text;
        private TextBox damageFee_Text;
        private Button addDamage_Button;
        private Label label5;
        private TextBox totalFee_Text;
        private Label label6;
        private ComboBox Method_ComboBox;
        private Button Refresh_Button;
        private Label label7;
        private Label label8;
        private DataGridView listRoom_DataGrid;
        private DataGridView listService_DataGrid;
        private Button Confirm_Button;
        private DataGridView damage_DataGrid;
        private Label label9;
        private Label label10;
        private TextBox depositPrice_Text;
        private Label label11;
        private Panel panel1;
        private Panel panel2;
        private Button Search_Button;
        private Button close_Button;
    }
}