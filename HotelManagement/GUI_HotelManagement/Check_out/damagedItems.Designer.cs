namespace GUI_HotelManagement
{
    partial class damagedItems
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
            this.damageList_DataGrid = new System.Windows.Forms.DataGridView();
            this.items_ComboBox = new System.Windows.Forms.ComboBox();
            this.ListRoom_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.amount_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.damageList_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // damageList_DataGrid
            // 
            this.damageList_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damageList_DataGrid.Location = new System.Drawing.Point(534, 228);
            this.damageList_DataGrid.Name = "damageList_DataGrid";
            this.damageList_DataGrid.RowHeadersWidth = 51;
            this.damageList_DataGrid.RowTemplate.Height = 29;
            this.damageList_DataGrid.Size = new System.Drawing.Size(293, 329);
            this.damageList_DataGrid.TabIndex = 0;
            // 
            // items_ComboBox
            // 
            this.items_ComboBox.Enabled = false;
            this.items_ComboBox.FormattingEnabled = true;
            this.items_ComboBox.Location = new System.Drawing.Point(611, 73);
            this.items_ComboBox.Name = "items_ComboBox";
            this.items_ComboBox.Size = new System.Drawing.Size(214, 28);
            this.items_ComboBox.TabIndex = 2;
            // 
            // ListRoom_Layout
            // 
            this.ListRoom_Layout.AllowDrop = true;
            this.ListRoom_Layout.AutoScroll = true;
            this.ListRoom_Layout.Location = new System.Drawing.Point(34, 105);
            this.ListRoom_Layout.Name = "ListRoom_Layout";
            this.ListRoom_Layout.Size = new System.Drawing.Size(466, 519);
            this.ListRoom_Layout.TabIndex = 3;
            // 
            // amount_Text
            // 
            this.amount_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount_Text.Enabled = false;
            this.amount_Text.Location = new System.Drawing.Point(611, 116);
            this.amount_Text.Name = "amount_Text";
            this.amount_Text.Size = new System.Drawing.Size(82, 27);
            this.amount_Text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(534, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(534, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(534, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "List damaged items:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button1.Location = new System.Drawing.Point(614, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Button.FlatAppearance.BorderSize = 0;
            this.add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_Button.ForeColor = System.Drawing.Color.White;
            this.add_Button.Location = new System.Drawing.Point(745, 113);
            this.add_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(81, 33);
            this.add_Button.TabIndex = 26;
            this.add_Button.Text = "+  Add";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ListRoom_Layout);
            this.panel1.Controls.Add(this.add_Button);
            this.panel1.Controls.Add(this.amount_Text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.items_ComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.damageList_DataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 649);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 93;
            this.label4.Text = "List rooms:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(321, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 37);
            this.label11.TabIndex = 92;
            this.label11.Text = "Add Damaged Item";
            // 
            // damagedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(882, 675);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "damagedItems";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.damageList_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView damageList_DataGrid;
        private ComboBox items_ComboBox;
        private FlowLayoutPanel ListRoom_Layout;
        private TextBox amount_Text;
        private Button add_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button5;
        private Panel panel1;
        private Label label11;
        private Label label4;
    }
}