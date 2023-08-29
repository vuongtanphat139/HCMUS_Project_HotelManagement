namespace HotelManagement
{
    partial class Services4Customer
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
            tabControl_services_for_customer = new TabControl();
            tabPage1 = new TabPage();
            dtgvRoomList = new DataGridView();
            panel1 = new Panel();
            btn_room_search = new Button();
            txbRoomID = new TextBox();
            lb_room_search = new Label();
            tabPage2 = new TabPage();
            dtgvTour = new DataGridView();
            panel2 = new Panel();
            txbError = new TextBox();
            label1 = new Label();
            timepickEnd = new DateTimePicker();
            timepickLeaving = new DateTimePicker();
            cbxDestination = new ComboBox();
            btn_tour_search = new Button();
            cbxDeparture = new ComboBox();
            lb_tour_search_tour_sort = new Label();
            lb_tour_search_leaving_time = new Label();
            lb_tour_search_des = new Label();
            lb_tour_search_dep = new Label();
            tabPage3 = new TabPage();
            dtgvServiceForm = new DataGridView();
            panel3 = new Panel();
            btnSearchServiceForm = new Button();
            tbSearchPhone = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            tabControl_services_for_customer.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRoomList).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTour).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvServiceForm).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_services_for_customer
            // 
            tabControl_services_for_customer.Controls.Add(tabPage1);
            tabControl_services_for_customer.Controls.Add(tabPage2);
            tabControl_services_for_customer.Controls.Add(tabPage3);
            tabControl_services_for_customer.Controls.Add(tabPage4);
            tabControl_services_for_customer.Location = new Point(9, 9);
            tabControl_services_for_customer.Margin = new Padding(2, 3, 2, 3);
            tabControl_services_for_customer.Name = "tabControl_services_for_customer";
            tabControl_services_for_customer.SelectedIndex = 0;
            tabControl_services_for_customer.Size = new Size(1097, 585);
            tabControl_services_for_customer.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtgvRoomList);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(1089, 552);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Room Search";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvRoomList
            // 
            dtgvRoomList.AllowUserToAddRows = false;
            dtgvRoomList.AllowUserToDeleteRows = false;
            dtgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRoomList.Location = new Point(5, 44);
            dtgvRoomList.Margin = new Padding(2, 3, 2, 3);
            dtgvRoomList.Name = "dtgvRoomList";
            dtgvRoomList.ReadOnly = true;
            dtgvRoomList.RowHeadersWidth = 62;
            dtgvRoomList.RowTemplate.Height = 33;
            dtgvRoomList.Size = new Size(827, 507);
            dtgvRoomList.TabIndex = 1;
            dtgvRoomList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_room_search);
            panel1.Controls.Add(txbRoomID);
            panel1.Controls.Add(lb_room_search);
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 35);
            panel1.TabIndex = 0;
            // 
            // btn_room_search
            // 
            btn_room_search.Location = new Point(389, 3);
            btn_room_search.Margin = new Padding(2, 3, 2, 3);
            btn_room_search.Name = "btn_room_search";
            btn_room_search.Size = new Size(89, 27);
            btn_room_search.TabIndex = 2;
            btn_room_search.Text = "Search";
            btn_room_search.UseVisualStyleBackColor = true;
            btn_room_search.Click += btn_room_search_Click;
            // 
            // txbRoomID
            // 
            txbRoomID.Location = new Point(73, 5);
            txbRoomID.Margin = new Padding(2, 3, 2, 3);
            txbRoomID.Name = "txbRoomID";
            txbRoomID.Size = new Size(222, 27);
            txbRoomID.TabIndex = 1;
            txbRoomID.TextChanged += textBox1_TextChanged;
            // 
            // lb_room_search
            // 
            lb_room_search.AutoSize = true;
            lb_room_search.Location = new Point(2, 7);
            lb_room_search.Margin = new Padding(2, 0, 2, 0);
            lb_room_search.Name = "lb_room_search";
            lb_room_search.Size = new Size(68, 20);
            lb_room_search.TabIndex = 0;
            lb_room_search.Text = "Room ID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgvTour);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(1089, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tour Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvTour
            // 
            dtgvTour.BackgroundColor = Color.Azure;
            dtgvTour.ColumnHeadersHeight = 34;
            dtgvTour.Location = new Point(5, 79);
            dtgvTour.Margin = new Padding(2, 3, 2, 3);
            dtgvTour.Name = "dtgvTour";
            dtgvTour.RowHeadersWidth = 62;
            dtgvTour.Size = new Size(1084, 467);
            dtgvTour.TabIndex = 0;
            dtgvTour.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(txbError);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(timepickEnd);
            panel2.Controls.Add(timepickLeaving);
            panel2.Controls.Add(cbxDestination);
            panel2.Controls.Add(btn_tour_search);
            panel2.Controls.Add(cbxDeparture);
            panel2.Controls.Add(lb_tour_search_tour_sort);
            panel2.Controls.Add(lb_tour_search_leaving_time);
            panel2.Controls.Add(lb_tour_search_des);
            panel2.Controls.Add(lb_tour_search_dep);
            panel2.ForeColor = Color.CadetBlue;
            panel2.Location = new Point(5, 3);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 71);
            panel2.TabIndex = 0;
            // 
            // txbError
            // 
            txbError.Location = new Point(800, 39);
            txbError.Name = "txbError";
            txbError.Size = new Size(43, 27);
            txbError.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 42);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 10;
            label1.Text = "Error:";
            // 
            // timepickEnd
            // 
            timepickEnd.Location = new Point(472, 37);
            timepickEnd.Name = "timepickEnd";
            timepickEnd.Size = new Size(250, 27);
            timepickEnd.TabIndex = 9;
            timepickEnd.ValueChanged += timepickEnd_ValueChanged;
            // 
            // timepickLeaving
            // 
            timepickLeaving.Location = new Point(105, 38);
            timepickLeaving.Name = "timepickLeaving";
            timepickLeaving.Size = new Size(250, 27);
            timepickLeaving.TabIndex = 3;
            timepickLeaving.ValueChanged += timepickLeaving_ValueChanged;
            // 
            // cbxDestination
            // 
            cbxDestination.FormattingEnabled = true;
            cbxDestination.Location = new Point(472, 7);
            cbxDestination.Name = "cbxDestination";
            cbxDestination.Size = new Size(250, 28);
            cbxDestination.TabIndex = 8;
            // 
            // btn_tour_search
            // 
            btn_tour_search.Location = new Point(902, 20);
            btn_tour_search.Margin = new Padding(2, 3, 2, 3);
            btn_tour_search.Name = "btn_tour_search";
            btn_tour_search.Size = new Size(89, 27);
            btn_tour_search.TabIndex = 0;
            btn_tour_search.Text = "Search tour";
            btn_tour_search.UseVisualStyleBackColor = true;
            btn_tour_search.Click += btn_tour_search_Click;
            // 
            // cbxDeparture
            // 
            cbxDeparture.FormattingEnabled = true;
            cbxDeparture.Location = new Point(105, 8);
            cbxDeparture.Name = "cbxDeparture";
            cbxDeparture.Size = new Size(250, 28);
            cbxDeparture.TabIndex = 1;
            // 
            // lb_tour_search_tour_sort
            // 
            lb_tour_search_tour_sort.AutoSize = true;
            lb_tour_search_tour_sort.Location = new Point(376, 37);
            lb_tour_search_tour_sort.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_tour_sort.Name = "lb_tour_search_tour_sort";
            lb_tour_search_tour_sort.Size = new Size(74, 20);
            lb_tour_search_tour_sort.TabIndex = 6;
            lb_tour_search_tour_sort.Text = "End Time:";
            // 
            // lb_tour_search_leaving_time
            // 
            lb_tour_search_leaving_time.AutoSize = true;
            lb_tour_search_leaving_time.Location = new Point(2, 37);
            lb_tour_search_leaving_time.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_leaving_time.Name = "lb_tour_search_leaving_time";
            lb_tour_search_leaving_time.Size = new Size(100, 20);
            lb_tour_search_leaving_time.TabIndex = 4;
            lb_tour_search_leaving_time.Text = "Leaving Time:";
            // 
            // lb_tour_search_des
            // 
            lb_tour_search_des.AutoSize = true;
            lb_tour_search_des.Location = new Point(376, 8);
            lb_tour_search_des.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_des.Name = "lb_tour_search_des";
            lb_tour_search_des.Size = new Size(88, 20);
            lb_tour_search_des.TabIndex = 2;
            lb_tour_search_des.Text = "Destination:";
            // 
            // lb_tour_search_dep
            // 
            lb_tour_search_dep.AutoSize = true;
            lb_tour_search_dep.Location = new Point(2, 7);
            lb_tour_search_dep.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_dep.Name = "lb_tour_search_dep";
            lb_tour_search_dep.Size = new Size(79, 20);
            lb_tour_search_dep.TabIndex = 0;
            lb_tour_search_dep.Text = "Departure:";
            lb_tour_search_dep.Click += label2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dtgvServiceForm);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 3, 2, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 3, 2, 3);
            tabPage3.Size = new Size(1089, 552);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Service Search";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgvServiceForm
            // 
            dtgvServiceForm.AllowUserToAddRows = false;
            dtgvServiceForm.AllowUserToDeleteRows = false;
            dtgvServiceForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServiceForm.Location = new Point(13, 49);
            dtgvServiceForm.Margin = new Padding(2, 3, 2, 3);
            dtgvServiceForm.Name = "dtgvServiceForm";
            dtgvServiceForm.ReadOnly = true;
            dtgvServiceForm.RowHeadersWidth = 62;
            dtgvServiceForm.RowTemplate.Height = 33;
            dtgvServiceForm.Size = new Size(827, 507);
            dtgvServiceForm.TabIndex = 3;
            dtgvServiceForm.CellContentClick += dtgvServiceForm_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearchServiceForm);
            panel3.Controls.Add(tbSearchPhone);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 10);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 35);
            panel3.TabIndex = 2;
            // 
            // btnSearchServiceForm
            // 
            btnSearchServiceForm.Location = new Point(539, 4);
            btnSearchServiceForm.Margin = new Padding(2, 3, 2, 3);
            btnSearchServiceForm.Name = "btnSearchServiceForm";
            btnSearchServiceForm.Size = new Size(89, 27);
            btnSearchServiceForm.TabIndex = 2;
            btnSearchServiceForm.Text = "Search";
            btnSearchServiceForm.UseVisualStyleBackColor = true;
            btnSearchServiceForm.Click += btnSearchServiceForm_Click;
            // 
            // tbSearchPhone
            // 
            tbSearchPhone.Location = new Point(198, 4);
            tbSearchPhone.Margin = new Padding(2, 3, 2, 3);
            tbSearchPhone.Name = "tbSearchPhone";
            tbSearchPhone.Size = new Size(222, 27);
            tbSearchPhone.TabIndex = 1;
            tbSearchPhone.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 0;
            label2.Text = "Phone number";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1089, 552);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Services4Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 624);
            Controls.Add(tabControl_services_for_customer);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Services4Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Services_for_customer";
            tabControl_services_for_customer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRoomList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTour).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvServiceForm).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_services_for_customer;
        private TabPage tabPage1;
        private DataGridView dtgvRoomList;
        private Panel panel1;
        private Button btn_room_search;
        private TextBox txbRoomID;
        private Label lb_room_search;
        private TabPage tabPage2;
        private Label lb_tour_search_dep;
        private Panel panel2;
        private TabPage tabPage3;
        private Label lb_tour_search_tour_sort;
        private Label lb_tour_search_leaving_time;
        private Label lb_tour_search_des;
        private DataGridView dtgvTour;
        private Button btn_tour_search;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn ID_ROOM;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn STATUS;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn TYPE;
        private ComboBox cbxTourType;
        private DateTimePicker timepickLeaving;
        private ComboBox cbxDestination;
        private ComboBox cbxDeparture;
        private DateTimePicker timepickEnd;
        private TextBox txbError;
        private Label label1;
        private DataGridView dtgvServiceForm;
        private Panel panel3;
        private Button btnSearchServiceForm;
        private TextBox tbSearchPhone;
        private Label label2;
        private TabPage tabPage4;
    }
}