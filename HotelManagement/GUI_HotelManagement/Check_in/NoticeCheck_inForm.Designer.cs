namespace GUI_HotelManagement
{
    partial class NoticeCheck_inForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Discount_DataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Service_Label = new System.Windows.Forms.Label();
            this.Rules_DataGrid = new System.Windows.Forms.DataGridView();
            this.ServiceHotel_DataGid = new System.Windows.Forms.DataGridView();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rules_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceHotel_DataGid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(699, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hotel rule:";
            // 
            // Discount_DataGrid
            // 
            this.Discount_DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.Discount_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discount_DataGrid.Location = new System.Drawing.Point(67, 541);
            this.Discount_DataGrid.Name = "Discount_DataGrid";
            this.Discount_DataGrid.ReadOnly = true;
            this.Discount_DataGrid.RowHeadersWidth = 51;
            this.Discount_DataGrid.RowTemplate.Height = 29;
            this.Discount_DataGrid.Size = new System.Drawing.Size(598, 240);
            this.Discount_DataGrid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(56, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Discount promotion atteched:";
            // 
            // Service_Label
            // 
            this.Service_Label.AutoSize = true;
            this.Service_Label.BackColor = System.Drawing.Color.White;
            this.Service_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Service_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Service_Label.Location = new System.Drawing.Point(56, 117);
            this.Service_Label.Name = "Service_Label";
            this.Service_Label.Size = new System.Drawing.Size(129, 25);
            this.Service_Label.TabIndex = 10;
            this.Service_Label.Text = "Hotel service:";
            // 
            // Rules_DataGrid
            // 
            this.Rules_DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.Rules_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rules_DataGrid.Location = new System.Drawing.Point(711, 168);
            this.Rules_DataGrid.Name = "Rules_DataGrid";
            this.Rules_DataGrid.ReadOnly = true;
            this.Rules_DataGrid.RowHeadersWidth = 51;
            this.Rules_DataGrid.RowTemplate.Height = 29;
            this.Rules_DataGrid.Size = new System.Drawing.Size(610, 613);
            this.Rules_DataGrid.TabIndex = 8;
            // 
            // ServiceHotel_DataGid
            // 
            this.ServiceHotel_DataGid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ServiceHotel_DataGid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceHotel_DataGid.Location = new System.Drawing.Point(56, 155);
            this.ServiceHotel_DataGid.Name = "ServiceHotel_DataGid";
            this.ServiceHotel_DataGid.ReadOnly = true;
            this.ServiceHotel_DataGid.RowHeadersWidth = 51;
            this.ServiceHotel_DataGid.RowTemplate.Height = 29;
            this.ServiceHotel_DataGid.Size = new System.Drawing.Size(598, 292);
            this.ServiceHotel_DataGid.TabIndex = 7;
            this.ServiceHotel_DataGid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceHotel_DataGid_CellContentClick);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.FlatAppearance.BorderSize = 2;
            this.Confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Confirm_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Confirm_Button.Location = new System.Drawing.Point(553, 805);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(249, 59);
            this.Confirm_Button.TabIndex = 14;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Confirm_Button);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ServiceHotel_DataGid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Service_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 907);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(353, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(670, 37);
            this.label6.TabIndex = 91;
            this.label6.Text = "CHECKIN (2) - NOTICE SERVICE, PROMOTION, RULE";
            // 
            // NoticeCheck_inForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1382, 933);
            this.Controls.Add(this.Discount_DataGrid);
            this.Controls.Add(this.Rules_DataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoticeCheck_inForm";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Text = "NoticeCheck_inForm";
            ((System.ComponentModel.ISupportInitialize)(this.Discount_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rules_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceHotel_DataGid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private DataGridView Discount_DataGrid;
        private Label label1;
        private Label Service_Label;
        private DataGridView Rules_DataGrid;
        private DataGridView ServiceHotel_DataGid;
        private Button Confirm_Button;
        private Panel panel1;
        private Label label6;
    }
}