namespace GUI_HotelManagement
{
    partial class ServiceForm
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
            this.Service_ComboBox = new System.Windows.Forms.ComboBox();
            this.Service_DataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Disable_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Floor_ComboBox = new System.Windows.Forms.ComboBox();
            this.Room_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceForRoom_DataGrid = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.UD_Panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UDService_ComboBox = new System.Windows.Forms.ComboBox();
            this.Discount_DataGid = new System.Windows.Forms.DataGridView();
            this.Infor_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Service_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceForRoom_DataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.UD_Panel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_DataGid)).BeginInit();
            this.SuspendLayout();
            // 
            // Service_ComboBox
            // 
            this.Service_ComboBox.FormattingEnabled = true;
            this.Service_ComboBox.Items.AddRange(new object[] {
            "All",
            "Dịch vụ hậu cần",
            "Dịch vụ kinh doanh"});
            this.Service_ComboBox.Location = new System.Drawing.Point(170, 56);
            this.Service_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Service_ComboBox.Name = "Service_ComboBox";
            this.Service_ComboBox.Size = new System.Drawing.Size(531, 28);
            this.Service_ComboBox.TabIndex = 0;
            this.Service_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Service_ComboBox_SelectedIndexChanged_1);
            // 
            // Service_DataGrid
            // 
            this.Service_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Service_DataGrid.Location = new System.Drawing.Point(31, 112);
            this.Service_DataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Service_DataGrid.Name = "Service_DataGrid";
            this.Service_DataGrid.ReadOnly = true;
            this.Service_DataGrid.RowHeadersWidth = 51;
            this.Service_DataGrid.RowTemplate.Height = 24;
            this.Service_DataGrid.Size = new System.Drawing.Size(671, 389);
            this.Service_DataGrid.TabIndex = 1;
            this.Service_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Service_DataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(51, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button2.Location = new System.Drawing.Point(59, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Disable_Button
            // 
            this.Disable_Button.FlatAppearance.BorderSize = 2;
            this.Disable_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disable_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disable_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.Disable_Button.Location = new System.Drawing.Point(277, 168);
            this.Disable_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Disable_Button.Name = "Disable_Button";
            this.Disable_Button.Size = new System.Drawing.Size(197, 51);
            this.Disable_Button.TabIndex = 4;
            this.Disable_Button.Text = "Disable";
            this.Disable_Button.UseVisualStyleBackColor = true;
            this.Disable_Button.Click += new System.EventHandler(this.Disable_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(738, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 0, 11, 13);
            this.panel1.Size = new System.Drawing.Size(560, 485);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Floor_ComboBox);
            this.panel3.Controls.Add(this.Room_ComboBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ServiceForRoom_DataGrid);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(11, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 472);
            this.panel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "List services of selected room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Floor:";
            // 
            // Floor_ComboBox
            // 
            this.Floor_ComboBox.FormattingEnabled = true;
            this.Floor_ComboBox.Location = new System.Drawing.Point(112, 49);
            this.Floor_ComboBox.Name = "Floor_ComboBox";
            this.Floor_ComboBox.Size = new System.Drawing.Size(228, 28);
            this.Floor_ComboBox.TabIndex = 13;
            this.Floor_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Floor_ComboBox_SelectedIndexChanged_1);
            // 
            // Room_ComboBox
            // 
            this.Room_ComboBox.FormattingEnabled = true;
            this.Room_ComboBox.Location = new System.Drawing.Point(112, 84);
            this.Room_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Room_ComboBox.Name = "Room_ComboBox";
            this.Room_ComboBox.Size = new System.Drawing.Size(228, 28);
            this.Room_ComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room:";
            // 
            // ServiceForRoom_DataGrid
            // 
            this.ServiceForRoom_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceForRoom_DataGrid.Location = new System.Drawing.Point(51, 183);
            this.ServiceForRoom_DataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceForRoom_DataGrid.Name = "ServiceForRoom_DataGrid";
            this.ServiceForRoom_DataGrid.ReadOnly = true;
            this.ServiceForRoom_DataGrid.RowHeadersWidth = 51;
            this.ServiceForRoom_DataGrid.RowTemplate.Height = 24;
            this.ServiceForRoom_DataGrid.Size = new System.Drawing.Size(427, 232);
            this.ServiceForRoom_DataGrid.TabIndex = 2;
            this.ServiceForRoom_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceForRoom_DataGrid_CellContentClick_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button5.Location = new System.Drawing.Point(371, 49);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 68);
            this.button5.TabIndex = 4;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(738, 484);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.panel2.Size = new System.Drawing.Size(560, 133);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(11, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 133);
            this.panel4.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button4.Location = new System.Drawing.Point(277, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // UD_Panel
            // 
            this.UD_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.UD_Panel.Controls.Add(this.panel5);
            this.UD_Panel.Location = new System.Drawing.Point(738, 607);
            this.UD_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UD_Panel.Name = "UD_Panel";
            this.UD_Panel.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.UD_Panel.Size = new System.Drawing.Size(560, 288);
            this.UD_Panel.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.Disable_Button);
            this.panel5.Controls.Add(this.UDService_ComboBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(11, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 262);
            this.panel5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Service\'s name:";
            // 
            // UDService_ComboBox
            // 
            this.UDService_ComboBox.FormattingEnabled = true;
            this.UDService_ComboBox.Items.AddRange(new object[] {
            "ứgsgd"});
            this.UDService_ComboBox.Location = new System.Drawing.Point(59, 95);
            this.UDService_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UDService_ComboBox.Name = "UDService_ComboBox";
            this.UDService_ComboBox.Size = new System.Drawing.Size(413, 28);
            this.UDService_ComboBox.TabIndex = 5;
            // 
            // Discount_DataGid
            // 
            this.Discount_DataGid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discount_DataGid.Location = new System.Drawing.Point(31, 588);
            this.Discount_DataGid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Discount_DataGid.Name = "Discount_DataGid";
            this.Discount_DataGid.RowHeadersWidth = 51;
            this.Discount_DataGid.RowTemplate.Height = 24;
            this.Discount_DataGid.Size = new System.Drawing.Size(671, 191);
            this.Discount_DataGid.TabIndex = 10;
            // 
            // Infor_Label
            // 
            this.Infor_Label.AutoSize = true;
            this.Infor_Label.BackColor = System.Drawing.SystemColors.Window;
            this.Infor_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Infor_Label.Location = new System.Drawing.Point(31, 547);
            this.Infor_Label.Name = "Infor_Label";
            this.Infor_Label.Size = new System.Drawing.Size(369, 25);
            this.Infor_Label.TabIndex = 16;
            this.Infor_Label.Text = "List discount promotions of selected room:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Types of service:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel6.Location = new System.Drawing.Point(-3, 881);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(746, 13);
            this.panel6.TabIndex = 18;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 893);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Infor_Label);
            this.Controls.Add(this.Discount_DataGid);
            this.Controls.Add(this.UD_Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Service_DataGrid);
            this.Controls.Add(this.Service_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ServiceForm";
            this.Text = "Dịch vụ khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.Service_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceForRoom_DataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.UD_Panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_DataGid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Service_ComboBox;
        private DataGridView Service_DataGrid;
        private Button button1;
        private Button button2;
        private Button Disable_Button;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Panel UD_Panel;
        private ComboBox comboBox2;
        private Button button5;
        private DataGridView ServiceForRoom_DataGrid;
        private Label label2;
        private ComboBox Room_ComboBox;
        private DataGridView Discount_DataGid;
        private ComboBox Floor_ComboBox;
        private ComboBox UDService_ComboBox;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label Infor_Label;
        private Label label6;
        private Panel panel6;
    }
}