namespace BankManager
{
    partial class frmMainCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnruttien = new System.Windows.Forms.Button();
            this.btnChuyentien = new System.Windows.Forms.Button();
            this.btnthongtintk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(246, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManager.Properties.Resources.icons8_administrator_male_50;
            this.pictureBox1.Location = new System.Drawing.Point(187, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BankManager.Properties.Resources.icons8_online_money_transfer_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(332, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 93);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thông Tin Giao Dịch";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnruttien
            // 
            this.btnruttien.AllowDrop = true;
            this.btnruttien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnruttien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnruttien.ForeColor = System.Drawing.Color.White;
            this.btnruttien.Image = global::BankManager.Properties.Resources.icons8_euro_money_40;
            this.btnruttien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnruttien.Location = new System.Drawing.Point(208, 215);
            this.btnruttien.Name = "btnruttien";
            this.btnruttien.Size = new System.Drawing.Size(106, 93);
            this.btnruttien.TabIndex = 2;
            this.btnruttien.Text = "Rút\r\nTiền\r\n";
            this.btnruttien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnruttien.UseVisualStyleBackColor = false;
            this.btnruttien.Click += new System.EventHandler(this.btnruttien_Click);
            // 
            // btnChuyentien
            // 
            this.btnChuyentien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnChuyentien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyentien.ForeColor = System.Drawing.Color.White;
            this.btnChuyentien.Image = global::BankManager.Properties.Resources.icons8_cash_in_hand_40;
            this.btnChuyentien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChuyentien.Location = new System.Drawing.Point(332, 116);
            this.btnChuyentien.Name = "btnChuyentien";
            this.btnChuyentien.Size = new System.Drawing.Size(106, 93);
            this.btnChuyentien.TabIndex = 1;
            this.btnChuyentien.Text = "Chuyển Tiền";
            this.btnChuyentien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChuyentien.UseVisualStyleBackColor = false;
            this.btnChuyentien.Click += new System.EventHandler(this.btnChuyentien_Click);
            // 
            // btnthongtintk
            // 
            this.btnthongtintk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnthongtintk.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongtintk.ForeColor = System.Drawing.Color.White;
            this.btnthongtintk.Image = global::BankManager.Properties.Resources.icons8_contact_info_40;
            this.btnthongtintk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnthongtintk.Location = new System.Drawing.Point(208, 116);
            this.btnthongtintk.Name = "btnthongtintk";
            this.btnthongtintk.Size = new System.Drawing.Size(106, 93);
            this.btnthongtintk.TabIndex = 0;
            this.btnthongtintk.Text = "Thông Tin Tài Khoàn";
            this.btnthongtintk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthongtintk.UseVisualStyleBackColor = false;
            this.btnthongtintk.Click += new System.EventHandler(this.btnthongtintk_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(425, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 347);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "NHÓM 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 96);
            this.label2.TabIndex = 1;
            this.label2.Text = "    QUẢN LÍ \r\n TÀI KHOẢN \r\nNGÂN HÀNG";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankManager.Properties.Resources.bank_folded_icon;
            this.pictureBox2.Location = new System.Drawing.Point(21, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 131);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnruttien);
            this.Controls.Add(this.btnChuyentien);
            this.Controls.Add(this.btnthongtintk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmMainCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthongtintk;
        private System.Windows.Forms.Button btnruttien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuyentien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}