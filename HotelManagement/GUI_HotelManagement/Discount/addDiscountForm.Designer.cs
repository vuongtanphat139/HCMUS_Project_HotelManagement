namespace GUI_HotelManagement
{
    partial class addDiscountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameDiscount_Text = new System.Windows.Forms.TextBox();
            this.Start_Date = new System.Windows.Forms.DateTimePicker();
            this.End_Date = new System.Windows.Forms.DateTimePicker();
            this.Descript_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Type_CheckList = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PercentDiscount_Text = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountRequiment_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promotion\'s name:";
            // 
            // nameDiscount_Text
            // 
            this.nameDiscount_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameDiscount_Text.Location = new System.Drawing.Point(209, 89);
            this.nameDiscount_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameDiscount_Text.Name = "nameDiscount_Text";
            this.nameDiscount_Text.Size = new System.Drawing.Size(579, 27);
            this.nameDiscount_Text.TabIndex = 5;
            // 
            // Start_Date
            // 
            this.Start_Date.Location = new System.Drawing.Point(209, 152);
            this.Start_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(258, 27);
            this.Start_Date.TabIndex = 6;
            // 
            // End_Date
            // 
            this.End_Date.Location = new System.Drawing.Point(209, 197);
            this.End_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(258, 27);
            this.End_Date.TabIndex = 7;
            // 
            // Descript_Text
            // 
            this.Descript_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Descript_Text.Location = new System.Drawing.Point(209, 256);
            this.Descript_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Descript_Text.Multiline = true;
            this.Descript_Text.Name = "Descript_Text";
            this.Descript_Text.Size = new System.Drawing.Size(579, 107);
            this.Descript_Text.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type discount:";
            // 
            // Type_CheckList
            // 
            this.Type_CheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type_CheckList.FormattingEnabled = true;
            this.Type_CheckList.Items.AddRange(new object[] {
            "Giảm giá",
            "Miễn phí một sản phẩm",
            "Miễn phí toàn phần"});
            this.Type_CheckList.Location = new System.Drawing.Point(209, 392);
            this.Type_CheckList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type_CheckList.Name = "Type_CheckList";
            this.Type_CheckList.Size = new System.Drawing.Size(579, 44);
            this.Type_CheckList.TabIndex = 13;
            this.Type_CheckList.SelectedIndexChanged += new System.EventHandler(this.Type_CheckList_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Percent discoount:";
            // 
            // PercentDiscount_Text
            // 
            this.PercentDiscount_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercentDiscount_Text.Enabled = false;
            this.PercentDiscount_Text.Location = new System.Drawing.Point(209, 475);
            this.PercentDiscount_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PercentDiscount_Text.Name = "PercentDiscount_Text";
            this.PercentDiscount_Text.Size = new System.Drawing.Size(180, 27);
            this.PercentDiscount_Text.TabIndex = 15;
            this.PercentDiscount_Text.TextChanged += new System.EventHandler(this.PercentDiscount_Text_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.AmountRequiment_Text);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.PercentDiscount_Text);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Type_CheckList);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Descript_Text);
            this.panel2.Controls.Add(this.End_Date);
            this.panel2.Controls.Add(this.Start_Date);
            this.panel2.Controls.Add(this.nameDiscount_Text);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(11, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 649);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button1.Location = new System.Drawing.Point(469, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button5.Location = new System.Drawing.Point(251, 548);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 59);
            this.button5.TabIndex = 24;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.button4.Location = new System.Drawing.Point(810, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 48);
            this.button4.TabIndex = 23;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Finish date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Start date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(275, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(384, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "CREATE DISCOUNT PROMOTION";
            // 
            // AmountRequiment_Text
            // 
            this.AmountRequiment_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountRequiment_Text.Enabled = false;
            this.AmountRequiment_Text.Location = new System.Drawing.Point(591, 475);
            this.AmountRequiment_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AmountRequiment_Text.Name = "AmountRequiment_Text";
            this.AmountRequiment_Text.Size = new System.Drawing.Size(197, 27);
            this.AmountRequiment_Text.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(440, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Amount require:";
            // 
            // addDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 675);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addDiscountForm";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Text = "Thêm chương trình khuyến mãi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private TextBox nameDiscount_Text;
        private DateTimePicker Start_Date;
        private DateTimePicker End_Date;
        private TextBox Descript_Text;
        private Label label6;
        private CheckedListBox Type_CheckList;
        private Label label5;
        private TextBox PercentDiscount_Text;
        private Panel panel2;
        private TextBox AmountRequiment_Text;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Button button4;
        private Button button1;
        private Button button5;
    }
}