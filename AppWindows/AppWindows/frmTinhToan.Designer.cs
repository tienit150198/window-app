namespace AppWindows
{
    partial class frmTinhToan
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.gbNhap = new System.Windows.Forms.GroupBox();
            this.gbPhepTinh = new System.Windows.Forms.GroupBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.gbNhap.SuspendLayout();
            this.gbPhepTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(82, 32);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(110, 20);
            this.tbA.TabIndex = 0;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(82, 86);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(110, 20);
            this.tbB.TabIndex = 1;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(17, 32);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(59, 17);
            this.lbA.TabIndex = 2;
            this.lbA.Text = "Nhập A:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(17, 87);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(59, 17);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Nhập B:";
            // 
            // gbNhap
            // 
            this.gbNhap.BackColor = System.Drawing.Color.LightPink;
            this.gbNhap.Controls.Add(this.lbA);
            this.gbNhap.Controls.Add(this.tbB);
            this.gbNhap.Controls.Add(this.lbB);
            this.gbNhap.Controls.Add(this.tbA);
            this.gbNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbNhap.Location = new System.Drawing.Point(28, 12);
            this.gbNhap.Name = "gbNhap";
            this.gbNhap.Size = new System.Drawing.Size(241, 150);
            this.gbNhap.TabIndex = 3;
            this.gbNhap.TabStop = false;
            this.gbNhap.Text = "Nhập";
            // 
            // gbPhepTinh
            // 
            this.gbPhepTinh.BackColor = System.Drawing.Color.LightPink;
            this.gbPhepTinh.Controls.Add(this.btnChia);
            this.gbPhepTinh.Controls.Add(this.btnNhan);
            this.gbPhepTinh.Controls.Add(this.btnTru);
            this.gbPhepTinh.Controls.Add(this.btnCong);
            this.gbPhepTinh.ForeColor = System.Drawing.Color.Navy;
            this.gbPhepTinh.Location = new System.Drawing.Point(306, 13);
            this.gbPhepTinh.Name = "gbPhepTinh";
            this.gbPhepTinh.Size = new System.Drawing.Size(149, 149);
            this.gbPhepTinh.TabIndex = 4;
            this.gbPhepTinh.TabStop = false;
            this.gbPhepTinh.Text = "Phép Tính";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Enabled = false;
            this.tbKetQua.Location = new System.Drawing.Point(110, 184);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(340, 20);
            this.tbKetQua.TabIndex = 5;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.Red;
            this.lbKetQua.Location = new System.Drawing.Point(40, 184);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(64, 17);
            this.lbKetQua.TabIndex = 3;
            this.lbKetQua.Text = "Kết Quả:";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(28, 25);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(87, 23);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(28, 54);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(87, 23);
            this.btnTru.TabIndex = 0;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(28, 83);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(87, 23);
            this.btnNhan.TabIndex = 0;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(28, 112);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(87, 23);
            this.btnChia.TabIndex = 0;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // frmTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(521, 226);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.gbPhepTinh);
            this.Controls.Add(this.gbNhap);
            this.Name = "frmTinhToan";
            this.Text = "frmTinhToan";
            this.Load += new System.EventHandler(this.frmTinhToan_Load);
            this.gbNhap.ResumeLayout(false);
            this.gbNhap.PerformLayout();
            this.gbPhepTinh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.GroupBox gbNhap;
        private System.Windows.Forms.GroupBox gbPhepTinh;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Label lbKetQua;
    }
}