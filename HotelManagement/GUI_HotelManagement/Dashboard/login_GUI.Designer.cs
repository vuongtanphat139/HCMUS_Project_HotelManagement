namespace GUI_HotelManagement
{
    partial class login_GUI
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

        private void InitializeComponent()
        {
            InitializeComponent(btn_login);
        }

        private void InitializeComponent(Button btn_login)
        {
            InitializeComponent(btn_login, panel2);
        }

        private void InitializeComponent(Button btn_login, Panel panel2)
        {
            InitializeComponent(btn_login, panel2, label5);
        }

        private void InitializeComponent(Button btn_login, Panel panel2, Label label5)
        {
            InitializeComponent(btn_login, panel2, label5, label2);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button btn_login, Panel panel2, Label label5, Label label2)
        {
            btn_login = new Button();
            tb_User = new TextBox();
            tb_Pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            checkbox_ShowPass = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            btn_login.BackColor = Color.FromArgb(8, 48, 107);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            Font font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Font = font;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(888, 489);
            const string btn = "btn_login";
            btn_login.Name = btn;
            btn_login.Size = new Size(196, 63);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_User
            // 
            tb_User.BorderStyle = BorderStyle.FixedSingle;
            tb_User.Cursor = Cursors.IBeam;
            tb_User.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tb_User.Location = new Point(909, 290);
            tb_User.Name = "tb_User";
            tb_User.Size = new Size(276, 39);
            tb_User.TabIndex = 1;
            // 
            // tb_Pass
            // 
            tb_Pass.BackColor = Color.White;
            tb_Pass.BorderStyle = BorderStyle.FixedSingle;
            tb_Pass.Cursor = Cursors.IBeam;
            tb_Pass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Pass.Location = new Point(909, 362);
            tb_Pass.Name = "tb_Pass";
            tb_Pass.Size = new Size(276, 39);
            tb_Pass.TabIndex = 2;
            tb_Pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1213, 306);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "PROJECT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1213, 378);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "DOAN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 48, 107);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 761);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(80, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(checkbox_ShowPass);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_Pass);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tb_User);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1384, 761);
            panel2.TabIndex = 6;
            //panel2.Paint += panel2_Paint;
            // 
            // checkbox_ShowPass
            // 
            checkbox_ShowPass.AutoSize = true;
            checkbox_ShowPass.Cursor = Cursors.Hand;
            checkbox_ShowPass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkbox_ShowPass.ForeColor = Color.FromArgb(8, 48, 107);
            checkbox_ShowPass.Location = new Point(909, 425);
            checkbox_ShowPass.Name = "checkbox_ShowPass";
            checkbox_ShowPass.Size = new Size(162, 29);
            checkbox_ShowPass.TabIndex = 8;
            checkbox_ShowPass.Text = "Show password";
            checkbox_ShowPass.UseVisualStyleBackColor = true;
            //checkbox_ShowPass.CheckedChanged += checkbox_ShowPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(8, 48, 107);
            label5.Location = new Point(738, 362);
            label5.Name = "label5";
            label5.Size = new Size(146, 37);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(738, 288);
            label4.Name = "label4";
            label4.Size = new Size(153, 37);
            label4.TabIndex = 6;
            label4.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(8, 48, 107);
            label3.Location = new Point(888, 178);
            label3.Name = "label3";
            label3.Size = new Size(196, 72);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // login_GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1384, 761);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "login_GUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login_GUI";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private TextBox tb_User;
        private TextBox tb_Pass;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox checkbox_ShowPass;
    }
}