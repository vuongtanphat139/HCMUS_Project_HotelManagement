namespace GUI_HotelManagement
{
    partial class Room_Form
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
            this.ListRoom_FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Filter_ComboBox = new System.Windows.Forms.ComboBox();
            this.Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRoom_FlowLayout
            // 
            this.ListRoom_FlowLayout.AutoScroll = true;
            this.ListRoom_FlowLayout.BackColor = System.Drawing.Color.White;
            this.ListRoom_FlowLayout.Location = new System.Drawing.Point(50, 219);
            this.ListRoom_FlowLayout.Name = "ListRoom_FlowLayout";
            this.ListRoom_FlowLayout.Size = new System.Drawing.Size(1184, 595);
            this.ListRoom_FlowLayout.TabIndex = 1;
            // 
            // Filter_ComboBox
            // 
            this.Filter_ComboBox.FormattingEnabled = true;
            this.Filter_ComboBox.Items.AddRange(new object[] {
            "All",
            "Status",
            "Type"});
            this.Filter_ComboBox.Location = new System.Drawing.Point(86, 39);
            this.Filter_ComboBox.Name = "Filter_ComboBox";
            this.Filter_ComboBox.Size = new System.Drawing.Size(437, 28);
            this.Filter_ComboBox.TabIndex = 2;
            this.Filter_ComboBox.Text = "All";
            this.Filter_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_ComboBox_SelectedIndexChanged_1);
            // 
            // Status_ComboBox
            // 
            this.Status_ComboBox.FormattingEnabled = true;
            this.Status_ComboBox.Items.AddRange(new object[] {
            "All",
            "Trống",
            "Được đặt trước",
            "Đang sử dụng"});
            this.Status_ComboBox.Location = new System.Drawing.Point(664, 37);
            this.Status_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Status_ComboBox.Name = "Status_ComboBox";
            this.Status_ComboBox.Size = new System.Drawing.Size(175, 28);
            this.Status_ComboBox.TabIndex = 3;
            this.Status_ComboBox.Text = "All";
            this.Status_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Status_ComboBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(598, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(909, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type:";
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Items.AddRange(new object[] {
            "All",
            "Phòng 2 ng",
            "Phòng 4 ng",
            "Phòng 8 ng",
            "Phòng vip "});
            this.Type_ComboBox.Location = new System.Drawing.Point(965, 37);
            this.Type_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(171, 28);
            this.Type_ComboBox.TabIndex = 7;
            this.Type_ComboBox.Text = "All";
            this.Type_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Type_ComboBox_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 880);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(566, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "List of Rooms";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.Filter_ComboBox);
            this.panel2.Controls.Add(this.Type_ComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Status_ComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(50, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 113);
            this.panel2.TabIndex = 19;
            // 
            // Room_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1297, 893);
            this.Controls.Add(this.ListRoom_FlowLayout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room_Form";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 11, 13);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel ListRoom_FlowLayout;
        private ComboBox Filter_ComboBox;
        private ComboBox Status_ComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox Type_ComboBox;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
    }
}