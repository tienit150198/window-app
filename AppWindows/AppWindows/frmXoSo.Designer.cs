namespace AppWindows
{
    partial class frmXoSo
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
            this.components = new System.ComponentModel.Container();
            this.grQuaySo = new System.Windows.Forms.GroupBox();
            this.cbChayToanBo = new System.Windows.Forms.CheckBox();
            this.nbSleep = new System.Windows.Forms.NumericUpDown();
            this.lbSleep = new System.Windows.Forms.Label();
            this.cbbGiaiThuong = new System.Windows.Forms.ComboBox();
            this.dtNgayQuay = new System.Windows.Forms.DateTimePicker();
            this.lbCongTy_edit = new System.Windows.Forms.Label();
            this.lbGiaiThuong = new System.Windows.Forms.Label();
            this.lbCongTy = new System.Windows.Forms.Label();
            this.lbNgayQuay = new System.Windows.Forms.Label();
            this.grGiaiThuong = new System.Windows.Forms.GroupBox();
            this.lbQuayThuong = new System.Windows.Forms.Label();
            this.tbGiaiDacBiet = new System.Windows.Forms.TextBox();
            this.tbGiaiNhat = new System.Windows.Forms.TextBox();
            this.tbGiaiNhi = new System.Windows.Forms.TextBox();
            this.tbGiaiBa = new System.Windows.Forms.TextBox();
            this.tbGiaiBon = new System.Windows.Forms.TextBox();
            this.tbGiaiNam = new System.Windows.Forms.TextBox();
            this.tbGiaiSau = new System.Windows.Forms.TextBox();
            this.tbGiaiBay = new System.Windows.Forms.TextBox();
            this.tbGiaiTam = new System.Windows.Forms.TextBox();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbNhi = new System.Windows.Forms.Label();
            this.lbBa = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbDacBiet = new System.Windows.Forms.Label();
            this.lbNhat = new System.Windows.Forms.Label();
            this.lbSau = new System.Windows.Forms.Label();
            this.lbBay = new System.Windows.Forms.Label();
            this.lbTam = new System.Windows.Forms.Label();
            this.btnQuayThuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timerQuay = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.timerQuayAll = new System.Windows.Forms.Timer(this.components);
            this.lbTienThuong = new System.Windows.Forms.Label();
            this.cbbTrungThuong = new System.Windows.Forms.ComboBox();
            this.tbXoSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grQuaySo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSleep)).BeginInit();
            this.grGiaiThuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grQuaySo
            // 
            this.grQuaySo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grQuaySo.Controls.Add(this.label1);
            this.grQuaySo.Controls.Add(this.tbXoSo);
            this.grQuaySo.Controls.Add(this.cbbTrungThuong);
            this.grQuaySo.Controls.Add(this.lbTienThuong);
            this.grQuaySo.Controls.Add(this.cbChayToanBo);
            this.grQuaySo.Controls.Add(this.nbSleep);
            this.grQuaySo.Controls.Add(this.lbSleep);
            this.grQuaySo.Controls.Add(this.cbbGiaiThuong);
            this.grQuaySo.Controls.Add(this.dtNgayQuay);
            this.grQuaySo.Controls.Add(this.lbCongTy_edit);
            this.grQuaySo.Controls.Add(this.lbGiaiThuong);
            this.grQuaySo.Controls.Add(this.lbCongTy);
            this.grQuaySo.Controls.Add(this.lbNgayQuay);
            this.grQuaySo.Location = new System.Drawing.Point(31, 32);
            this.grQuaySo.Name = "grQuaySo";
            this.grQuaySo.Size = new System.Drawing.Size(657, 124);
            this.grQuaySo.TabIndex = 1;
            this.grQuaySo.TabStop = false;
            this.grQuaySo.Text = "Thông tin quay số";
            // 
            // cbChayToanBo
            // 
            this.cbChayToanBo.AutoSize = true;
            this.cbChayToanBo.Location = new System.Drawing.Point(491, 62);
            this.cbChayToanBo.Name = "cbChayToanBo";
            this.cbChayToanBo.Size = new System.Drawing.Size(89, 17);
            this.cbChayToanBo.TabIndex = 8;
            this.cbChayToanBo.Text = "Chạy toàn bộ";
            this.cbChayToanBo.UseVisualStyleBackColor = true;
            this.cbChayToanBo.CheckedChanged += new System.EventHandler(this.cbChayToanBo_CheckedChanged);
            // 
            // nbSleep
            // 
            this.nbSleep.Location = new System.Drawing.Point(108, 59);
            this.nbSleep.Name = "nbSleep";
            this.nbSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nbSleep.Size = new System.Drawing.Size(40, 20);
            this.nbSleep.TabIndex = 7;
            this.nbSleep.ValueChanged += new System.EventHandler(this.nbSleep_ValueChanged);
            // 
            // lbSleep
            // 
            this.lbSleep.AutoSize = true;
            this.lbSleep.ForeColor = System.Drawing.Color.Red;
            this.lbSleep.Location = new System.Drawing.Point(22, 63);
            this.lbSleep.Name = "lbSleep";
            this.lbSleep.Size = new System.Drawing.Size(80, 13);
            this.lbSleep.TabIndex = 6;
            this.lbSleep.Text = "Thời gian quay:";
            // 
            // cbbGiaiThuong
            // 
            this.cbbGiaiThuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiaiThuong.FormattingEnabled = true;
            this.cbbGiaiThuong.Location = new System.Drawing.Point(491, 22);
            this.cbbGiaiThuong.Name = "cbbGiaiThuong";
            this.cbbGiaiThuong.Size = new System.Drawing.Size(121, 21);
            this.cbbGiaiThuong.TabIndex = 3;
            this.cbbGiaiThuong.SelectedIndexChanged += new System.EventHandler(this.cbbGiaiThuong_SelectedIndexChanged);
            // 
            // dtNgayQuay
            // 
            this.dtNgayQuay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayQuay.Location = new System.Drawing.Point(88, 23);
            this.dtNgayQuay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayQuay.Name = "dtNgayQuay";
            this.dtNgayQuay.Size = new System.Drawing.Size(99, 20);
            this.dtNgayQuay.TabIndex = 2;
            this.dtNgayQuay.Value = new System.DateTime(2019, 10, 29, 0, 0, 0, 0);
            this.dtNgayQuay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbCongTy_edit
            // 
            this.lbCongTy_edit.AutoSize = true;
            this.lbCongTy_edit.Location = new System.Drawing.Point(314, 99);
            this.lbCongTy_edit.Name = "lbCongTy_edit";
            this.lbCongTy_edit.Size = new System.Drawing.Size(0, 13);
            this.lbCongTy_edit.TabIndex = 1;
            // 
            // lbGiaiThuong
            // 
            this.lbGiaiThuong.AutoSize = true;
            this.lbGiaiThuong.ForeColor = System.Drawing.Color.Red;
            this.lbGiaiThuong.Location = new System.Drawing.Point(457, 26);
            this.lbGiaiThuong.Name = "lbGiaiThuong";
            this.lbGiaiThuong.Size = new System.Drawing.Size(28, 13);
            this.lbGiaiThuong.TabIndex = 0;
            this.lbGiaiThuong.Text = "Giải:";
            this.lbGiaiThuong.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCongTy
            // 
            this.lbCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongTy.ForeColor = System.Drawing.Color.Red;
            this.lbCongTy.Location = new System.Drawing.Point(18, 81);
            this.lbCongTy.Name = "lbCongTy";
            this.lbCongTy.Size = new System.Drawing.Size(613, 37);
            this.lbCongTy.TabIndex = 0;
            this.lbCongTy.Text = "Công ty Xổ số Xuyên Quốc Gia";
            this.lbCongTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCongTy.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNgayQuay
            // 
            this.lbNgayQuay.AutoSize = true;
            this.lbNgayQuay.ForeColor = System.Drawing.Color.Red;
            this.lbNgayQuay.Location = new System.Drawing.Point(21, 26);
            this.lbNgayQuay.Name = "lbNgayQuay";
            this.lbNgayQuay.Size = new System.Drawing.Size(61, 13);
            this.lbNgayQuay.TabIndex = 0;
            this.lbNgayQuay.Text = "Ngày quay:";
            // 
            // grGiaiThuong
            // 
            this.grGiaiThuong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grGiaiThuong.Controls.Add(this.lbQuayThuong);
            this.grGiaiThuong.Controls.Add(this.tbGiaiDacBiet);
            this.grGiaiThuong.Controls.Add(this.tbGiaiNhat);
            this.grGiaiThuong.Controls.Add(this.tbGiaiNhi);
            this.grGiaiThuong.Controls.Add(this.tbGiaiBa);
            this.grGiaiThuong.Controls.Add(this.tbGiaiBon);
            this.grGiaiThuong.Controls.Add(this.tbGiaiNam);
            this.grGiaiThuong.Controls.Add(this.tbGiaiSau);
            this.grGiaiThuong.Controls.Add(this.tbGiaiBay);
            this.grGiaiThuong.Controls.Add(this.tbGiaiTam);
            this.grGiaiThuong.Controls.Add(this.lbNam);
            this.grGiaiThuong.Controls.Add(this.lbNhi);
            this.grGiaiThuong.Controls.Add(this.lbBa);
            this.grGiaiThuong.Controls.Add(this.lbTu);
            this.grGiaiThuong.Controls.Add(this.lbDacBiet);
            this.grGiaiThuong.Controls.Add(this.lbNhat);
            this.grGiaiThuong.Controls.Add(this.lbSau);
            this.grGiaiThuong.Controls.Add(this.lbBay);
            this.grGiaiThuong.Controls.Add(this.lbTam);
            this.grGiaiThuong.Location = new System.Drawing.Point(31, 177);
            this.grGiaiThuong.Name = "grGiaiThuong";
            this.grGiaiThuong.Size = new System.Drawing.Size(757, 261);
            this.grGiaiThuong.TabIndex = 2;
            this.grGiaiThuong.TabStop = false;
            this.grGiaiThuong.Text = "Thông tin giải thưởng";
            // 
            // lbQuayThuong
            // 
            this.lbQuayThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuayThuong.ForeColor = System.Drawing.Color.Red;
            this.lbQuayThuong.Location = new System.Drawing.Point(616, 224);
            this.lbQuayThuong.Name = "lbQuayThuong";
            this.lbQuayThuong.Size = new System.Drawing.Size(122, 23);
            this.lbQuayThuong.TabIndex = 9;
            this.lbQuayThuong.Click += new System.EventHandler(this.lbQuayThuong_Click);
            // 
            // tbGiaiDacBiet
            // 
            this.tbGiaiDacBiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiDacBiet.ForeColor = System.Drawing.Color.Red;
            this.tbGiaiDacBiet.Location = new System.Drawing.Point(288, 224);
            this.tbGiaiDacBiet.Name = "tbGiaiDacBiet";
            this.tbGiaiDacBiet.ReadOnly = true;
            this.tbGiaiDacBiet.Size = new System.Drawing.Size(255, 23);
            this.tbGiaiDacBiet.TabIndex = 8;
            this.tbGiaiDacBiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiNhat
            // 
            this.tbGiaiNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiNhat.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiNhat.Location = new System.Drawing.Point(417, 180);
            this.tbGiaiNhat.Multiline = true;
            this.tbGiaiNhat.Name = "tbGiaiNhat";
            this.tbGiaiNhat.ReadOnly = true;
            this.tbGiaiNhat.Size = new System.Drawing.Size(321, 20);
            this.tbGiaiNhat.TabIndex = 7;
            this.tbGiaiNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiNhi
            // 
            this.tbGiaiNhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiNhi.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiNhi.Location = new System.Drawing.Point(417, 123);
            this.tbGiaiNhi.Multiline = true;
            this.tbGiaiNhi.Name = "tbGiaiNhi";
            this.tbGiaiNhi.ReadOnly = true;
            this.tbGiaiNhi.Size = new System.Drawing.Size(321, 20);
            this.tbGiaiNhi.TabIndex = 6;
            this.tbGiaiNhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiBa
            // 
            this.tbGiaiBa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiBa.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiBa.Location = new System.Drawing.Point(417, 79);
            this.tbGiaiBa.Multiline = true;
            this.tbGiaiBa.Name = "tbGiaiBa";
            this.tbGiaiBa.ReadOnly = true;
            this.tbGiaiBa.Size = new System.Drawing.Size(321, 20);
            this.tbGiaiBa.TabIndex = 5;
            this.tbGiaiBa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiBon
            // 
            this.tbGiaiBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiBon.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiBon.Location = new System.Drawing.Point(417, 28);
            this.tbGiaiBon.Multiline = true;
            this.tbGiaiBon.Name = "tbGiaiBon";
            this.tbGiaiBon.ReadOnly = true;
            this.tbGiaiBon.Size = new System.Drawing.Size(321, 20);
            this.tbGiaiBon.TabIndex = 4;
            this.tbGiaiBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiNam
            // 
            this.tbGiaiNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiNam.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiNam.Location = new System.Drawing.Point(88, 180);
            this.tbGiaiNam.Multiline = true;
            this.tbGiaiNam.Name = "tbGiaiNam";
            this.tbGiaiNam.ReadOnly = true;
            this.tbGiaiNam.Size = new System.Drawing.Size(255, 20);
            this.tbGiaiNam.TabIndex = 3;
            this.tbGiaiNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiSau
            // 
            this.tbGiaiSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiSau.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiSau.Location = new System.Drawing.Point(88, 123);
            this.tbGiaiSau.Multiline = true;
            this.tbGiaiSau.Name = "tbGiaiSau";
            this.tbGiaiSau.ReadOnly = true;
            this.tbGiaiSau.Size = new System.Drawing.Size(255, 20);
            this.tbGiaiSau.TabIndex = 2;
            this.tbGiaiSau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiBay
            // 
            this.tbGiaiBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiBay.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiBay.Location = new System.Drawing.Point(88, 76);
            this.tbGiaiBay.Multiline = true;
            this.tbGiaiBay.Name = "tbGiaiBay";
            this.tbGiaiBay.ReadOnly = true;
            this.tbGiaiBay.Size = new System.Drawing.Size(255, 20);
            this.tbGiaiBay.TabIndex = 1;
            this.tbGiaiBay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGiaiTam
            // 
            this.tbGiaiTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaiTam.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbGiaiTam.Location = new System.Drawing.Point(88, 28);
            this.tbGiaiTam.Multiline = true;
            this.tbGiaiTam.Name = "tbGiaiTam";
            this.tbGiaiTam.ReadOnly = true;
            this.tbGiaiTam.Size = new System.Drawing.Size(255, 20);
            this.tbGiaiTam.TabIndex = 1;
            this.tbGiaiTam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.ForeColor = System.Drawing.Color.Blue;
            this.lbNam.Location = new System.Drawing.Point(21, 178);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(48, 13);
            this.lbNam.TabIndex = 0;
            this.lbNam.Text = "Giải năm";
            this.lbNam.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbNhi
            // 
            this.lbNhi.AutoSize = true;
            this.lbNhi.ForeColor = System.Drawing.Color.Blue;
            this.lbNhi.Location = new System.Drawing.Point(371, 123);
            this.lbNhi.Name = "lbNhi";
            this.lbNhi.Size = new System.Drawing.Size(45, 13);
            this.lbNhi.TabIndex = 0;
            this.lbNhi.Text = "Giải nhì:";
            // 
            // lbBa
            // 
            this.lbBa.AutoSize = true;
            this.lbBa.ForeColor = System.Drawing.Color.Blue;
            this.lbBa.Location = new System.Drawing.Point(371, 79);
            this.lbBa.Name = "lbBa";
            this.lbBa.Size = new System.Drawing.Size(43, 13);
            this.lbBa.TabIndex = 0;
            this.lbBa.Text = "Giải ba:";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.ForeColor = System.Drawing.Color.Blue;
            this.lbTu.Location = new System.Drawing.Point(371, 33);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(40, 13);
            this.lbTu.TabIndex = 0;
            this.lbTu.Text = "Giải tư:";
            // 
            // lbDacBiet
            // 
            this.lbDacBiet.AutoSize = true;
            this.lbDacBiet.ForeColor = System.Drawing.Color.Red;
            this.lbDacBiet.Location = new System.Drawing.Point(212, 231);
            this.lbDacBiet.Name = "lbDacBiet";
            this.lbDacBiet.Size = new System.Drawing.Size(70, 13);
            this.lbDacBiet.TabIndex = 0;
            this.lbDacBiet.Text = "Giải đặc biệt:";
            // 
            // lbNhat
            // 
            this.lbNhat.AutoSize = true;
            this.lbNhat.ForeColor = System.Drawing.Color.Blue;
            this.lbNhat.Location = new System.Drawing.Point(368, 184);
            this.lbNhat.Name = "lbNhat";
            this.lbNhat.Size = new System.Drawing.Size(52, 13);
            this.lbNhat.TabIndex = 0;
            this.lbNhat.Text = "Giải nhất:";
            // 
            // lbSau
            // 
            this.lbSau.AutoSize = true;
            this.lbSau.ForeColor = System.Drawing.Color.Blue;
            this.lbSau.Location = new System.Drawing.Point(21, 123);
            this.lbSau.Name = "lbSau";
            this.lbSau.Size = new System.Drawing.Size(48, 13);
            this.lbSau.TabIndex = 0;
            this.lbSau.Text = "Giải sáu:";
            // 
            // lbBay
            // 
            this.lbBay.AutoSize = true;
            this.lbBay.ForeColor = System.Drawing.Color.Blue;
            this.lbBay.Location = new System.Drawing.Point(21, 79);
            this.lbBay.Name = "lbBay";
            this.lbBay.Size = new System.Drawing.Size(45, 13);
            this.lbBay.TabIndex = 0;
            this.lbBay.Text = "Giải bảy";
            // 
            // lbTam
            // 
            this.lbTam.AutoSize = true;
            this.lbTam.ForeColor = System.Drawing.Color.Blue;
            this.lbTam.Location = new System.Drawing.Point(21, 33);
            this.lbTam.Name = "lbTam";
            this.lbTam.Size = new System.Drawing.Size(48, 13);
            this.lbTam.TabIndex = 0;
            this.lbTam.Text = "Giải tám:";
            // 
            // btnQuayThuong
            // 
            this.btnQuayThuong.Location = new System.Drawing.Point(694, 42);
            this.btnQuayThuong.Name = "btnQuayThuong";
            this.btnQuayThuong.Size = new System.Drawing.Size(75, 23);
            this.btnQuayThuong.TabIndex = 3;
            this.btnQuayThuong.Text = "Quay";
            this.btnQuayThuong.UseVisualStyleBackColor = true;
            this.btnQuayThuong.Click += new System.EventHandler(this.btnQuayThuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(694, 101);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerQuay
            // 
            this.timerQuay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(695, 72);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timerQuayAll
            // 
            this.timerQuayAll.Tick += new System.EventHandler(this.timerQuayAll_Tick);
            // 
            // lbTienThuong
            // 
            this.lbTienThuong.AutoSize = true;
            this.lbTienThuong.ForeColor = System.Drawing.Color.Red;
            this.lbTienThuong.Location = new System.Drawing.Point(219, 26);
            this.lbTienThuong.Name = "lbTienThuong";
            this.lbTienThuong.Size = new System.Drawing.Size(64, 13);
            this.lbTienThuong.TabIndex = 9;
            this.lbTienThuong.Text = "Giải thưởng:";
            // 
            // cbbTrungThuong
            // 
            this.cbbTrungThuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrungThuong.FormattingEnabled = true;
            this.cbbTrungThuong.Location = new System.Drawing.Point(288, 23);
            this.cbbTrungThuong.Name = "cbbTrungThuong";
            this.cbbTrungThuong.Size = new System.Drawing.Size(121, 21);
            this.cbbTrungThuong.TabIndex = 10;
            this.cbbTrungThuong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbXoSo
            // 
            this.tbXoSo.Location = new System.Drawing.Point(290, 59);
            this.tbXoSo.Name = "tbXoSo";
            this.tbXoSo.Size = new System.Drawing.Size(121, 20);
            this.tbXoSo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xổ số:";
            // 
            // frmXoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuayThuong);
            this.Controls.Add(this.grGiaiThuong);
            this.Controls.Add(this.grQuaySo);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXoSo";
            this.Text = "Xổ số kiến thiết xuyên quốc gia";
            this.Load += new System.EventHandler(this.frmXoSo_Load);
            this.grQuaySo.ResumeLayout(false);
            this.grQuaySo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSleep)).EndInit();
            this.grGiaiThuong.ResumeLayout(false);
            this.grGiaiThuong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grQuaySo;
        private System.Windows.Forms.Label lbCongTy;
        private System.Windows.Forms.Label lbNgayQuay;
        private System.Windows.Forms.GroupBox grGiaiThuong;
        private System.Windows.Forms.DateTimePicker dtNgayQuay;
        private System.Windows.Forms.Label lbCongTy_edit;
        private System.Windows.Forms.ComboBox cbbGiaiThuong;
        private System.Windows.Forms.Label lbGiaiThuong;
        private System.Windows.Forms.Button btnQuayThuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbNhi;
        private System.Windows.Forms.Label lbBa;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDacBiet;
        private System.Windows.Forms.Label lbNhat;
        private System.Windows.Forms.Label lbSau;
        private System.Windows.Forms.Label lbBay;
        private System.Windows.Forms.Label lbTam;
        private System.Windows.Forms.Label lbSleep;
        private System.Windows.Forms.Timer timerQuay;
        private System.Windows.Forms.NumericUpDown nbSleep;
        private System.Windows.Forms.TextBox tbGiaiDacBiet;
        private System.Windows.Forms.TextBox tbGiaiNhat;
        private System.Windows.Forms.TextBox tbGiaiNhi;
        private System.Windows.Forms.TextBox tbGiaiBa;
        private System.Windows.Forms.TextBox tbGiaiBon;
        private System.Windows.Forms.TextBox tbGiaiNam;
        private System.Windows.Forms.TextBox tbGiaiSau;
        private System.Windows.Forms.TextBox tbGiaiBay;
        private System.Windows.Forms.TextBox tbGiaiTam;
        private System.Windows.Forms.Label lbQuayThuong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbChayToanBo;
        private System.Windows.Forms.Timer timerQuayAll;
        private System.Windows.Forms.ComboBox cbbTrungThuong;
        private System.Windows.Forms.Label lbTienThuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbXoSo;
    }
}