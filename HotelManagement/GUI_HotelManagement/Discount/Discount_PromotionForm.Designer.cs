namespace GUI_HotelManagement
{
    partial class Discount_PromotionForm
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
            this.Discount_DataGrid = new System.Windows.Forms.DataGridView();
            this.End_DataTime = new System.Windows.Forms.DateTimePicker();
            this.Start_DataTime = new System.Windows.Forms.DateTimePicker();
            this.ServiceID_ComboBox = new System.Windows.Forms.ComboBox();
            this.idDiscount_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UD_Panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Disable_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_DataGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.UD_Panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Discount_DataGrid
            // 
            this.Discount_DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.Discount_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discount_DataGrid.Location = new System.Drawing.Point(51, 92);
            this.Discount_DataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Discount_DataGrid.Name = "Discount_DataGrid";
            this.Discount_DataGrid.RowHeadersWidth = 51;
            this.Discount_DataGrid.RowTemplate.Height = 24;
            this.Discount_DataGrid.Size = new System.Drawing.Size(542, 521);
            this.Discount_DataGrid.TabIndex = 1;
            this.Discount_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Discount_DataGrid_CellContentClick);
            // 
            // End_DataTime
            // 
            this.End_DataTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End_DataTime.Location = new System.Drawing.Point(131, 145);
            this.End_DataTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.End_DataTime.Name = "End_DataTime";
            this.End_DataTime.Size = new System.Drawing.Size(278, 34);
            this.End_DataTime.TabIndex = 8;
            // 
            // Start_DataTime
            // 
            this.Start_DataTime.CalendarFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_DataTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_DataTime.Location = new System.Drawing.Point(131, 94);
            this.Start_DataTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_DataTime.Name = "Start_DataTime";
            this.Start_DataTime.Size = new System.Drawing.Size(278, 34);
            this.Start_DataTime.TabIndex = 7;
            // 
            // ServiceID_ComboBox
            // 
            this.ServiceID_ComboBox.BackColor = System.Drawing.Color.White;
            this.ServiceID_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceID_ComboBox.FormattingEnabled = true;
            this.ServiceID_ComboBox.Location = new System.Drawing.Point(131, 44);
            this.ServiceID_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceID_ComboBox.Name = "ServiceID_ComboBox";
            this.ServiceID_ComboBox.Size = new System.Drawing.Size(278, 36);
            this.ServiceID_ComboBox.TabIndex = 0;
            // 
            // idDiscount_ComboBox
            // 
            this.idDiscount_ComboBox.BackColor = System.Drawing.Color.White;
            this.idDiscount_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idDiscount_ComboBox.FormattingEnabled = true;
            this.idDiscount_ComboBox.Location = new System.Drawing.Point(47, 91);
            this.idDiscount_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idDiscount_ComboBox.Name = "idDiscount_ComboBox";
            this.idDiscount_ComboBox.Size = new System.Drawing.Size(371, 36);
            this.idDiscount_ComboBox.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.UD_Panel);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1123, 657);
            this.panel4.TabIndex = 6;
            // 
            // UD_Panel
            // 
            this.UD_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.UD_Panel.Controls.Add(this.panel5);
            this.UD_Panel.Location = new System.Drawing.Point(644, 409);
            this.UD_Panel.Name = "UD_Panel";
            this.UD_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.UD_Panel.Size = new System.Drawing.Size(490, 263);
            this.UD_Panel.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.idDiscount_ComboBox);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.Disable_Button);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 243);
            this.panel5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Discount promotion\'s name:";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button6.Location = new System.Drawing.Point(47, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 38);
            this.button6.TabIndex = 3;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Disable_Button
            // 
            this.Disable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Disable_Button.FlatAppearance.BorderSize = 2;
            this.Disable_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disable_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disable_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.Disable_Button.Location = new System.Drawing.Point(246, 146);
            this.Disable_Button.Name = "Disable_Button";
            this.Disable_Button.Size = new System.Drawing.Size(172, 38);
            this.Disable_Button.TabIndex = 4;
            this.Disable_Button.Text = "Delete";
            this.Disable_Button.UseVisualStyleBackColor = true;
            this.Disable_Button.Click += new System.EventHandler(this.Disable_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(644, 289);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(490, 175);
            this.panel1.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(470, 175);
            this.panel6.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button7.Location = new System.Drawing.Point(246, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 39);
            this.button7.TabIndex = 3;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button8.Location = new System.Drawing.Point(47, 43);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 39);
            this.button8.TabIndex = 2;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(644, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel7.Size = new System.Drawing.Size(490, 290);
            this.panel7.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Controls.Add(this.ServiceID_ComboBox);
            this.panel8.Controls.Add(this.End_DataTime);
            this.panel8.Controls.Add(this.Start_DataTime);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(10, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(470, 280);
            this.panel8.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Finish date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Floor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Start date:";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button9.Location = new System.Drawing.Point(187, 202);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 51);
            this.button9.TabIndex = 4;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(152, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 41);
            this.label4.TabIndex = 19;
            this.label4.Text = "List of Discount Promotion";
            // 
            // Discount_PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1135, 670);
            this.Controls.Add(this.Discount_DataGrid);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Discount_PromotionForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 12, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình khuyến mãi";
            ((System.ComponentModel.ISupportInitialize)(this.Discount_DataGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.UD_Panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView Discount_DataGrid;
        private ComboBox ServiceID_ComboBox;
        private ComboBox idDiscount_ComboBox;
        private DateTimePicker End_DataTime;
        private DateTimePicker Start_DataTime;
        private Panel panel4;
        private Label label4;
        private Panel UD_Panel;
        private Panel panel5;
        private Label label1;
        private Button button6;
        private Button Disable_Button;
        private Panel panel1;
        private Panel panel6;
        private Button button7;
        private Button button8;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private Label label6;
        private Button button9;
        private Label label3;
    }
}