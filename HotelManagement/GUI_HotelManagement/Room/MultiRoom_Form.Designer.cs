namespace GUI_HotelManagement
{
    partial class MultiRoom_Form
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
            ListRoom_FlowLayout = new FlowLayoutPanel();
            bookingRoom_DataGrid = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bookingRoom_DataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListRoom_FlowLayout
            // 
            ListRoom_FlowLayout.AutoScroll = true;
            ListRoom_FlowLayout.Location = new Point(37, 67);
            ListRoom_FlowLayout.Margin = new Padding(3, 2, 3, 2);
            ListRoom_FlowLayout.Name = "ListRoom_FlowLayout";
            ListRoom_FlowLayout.Size = new Size(688, 476);
            ListRoom_FlowLayout.TabIndex = 8;
            // 
            // bookingRoom_DataGrid
            // 
            bookingRoom_DataGrid.AllowUserToAddRows = false;
            bookingRoom_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingRoom_DataGrid.Location = new Point(761, 67);
            bookingRoom_DataGrid.Margin = new Padding(3, 2, 3, 2);
            bookingRoom_DataGrid.Name = "bookingRoom_DataGrid";
            bookingRoom_DataGrid.RowHeadersVisible = false;
            bookingRoom_DataGrid.RowHeadersWidth = 51;
            bookingRoom_DataGrid.RowTemplate.Height = 29;
            bookingRoom_DataGrid.Size = new Size(348, 382);
            bookingRoom_DataGrid.TabIndex = 9;
            bookingRoom_DataGrid.CellContentClick += bookingRoom_DataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(761, 39);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 11;
            label1.Text = "BookingRoom";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(8, 48, 107);
            button2.Location = new Point(861, 495);
            button2.Name = "button2";
            button2.Size = new Size(177, 48);
            button2.TabIndex = 28;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ListRoom_FlowLayout);
            panel1.Controls.Add(bookingRoom_DataGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 572);
            panel1.TabIndex = 29;
            // 
            // MultiRoom_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1173, 592);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MultiRoom_Form";
            Padding = new Padding(10);
            Text = "MultiRoom_Form";
            ((System.ComponentModel.ISupportInitialize)bookingRoom_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ListRoom_FlowLayout;
        private DataGridView bookingRoom_DataGrid;
        private Label label1;
        private Button button2;
        private Panel panel1;
    }
}