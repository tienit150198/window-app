using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppWindows
{
    public partial class frmXoSo : Form
    {
        List<infoXoSo> listXoSo = new List<infoXoSo>();
        List<TextBox> listTextBox = new List<TextBox>();
        List<int> listGiaiThuong = new List<int>();
        long trungthuong = 0;
        int sotien = 0;
        int sogiai = 0, sochuso = 0;
        string ten = "";
        TextBox tb = null;
        int totalSleep = 0;
        int sleepOneLoop = 0, timeout = 0, countLoop = 0, indexLoop = 0;
        Random rd = new Random();

        public frmXoSo()
        {
            InitializeComponent();
            timerQuay.Enabled = false;
            
            loadXoSo();
            loadCbb();
            loadGiaiThuong();
            setDate();
            setListTextBox();
        }

        public void loadXoSo()
        {
            listXoSo.Add(new infoXoSo("Giải Tám", 1, 2));
            listXoSo.Add(new infoXoSo("Giải Bảy", 2, 3));
            listXoSo.Add(new infoXoSo("Giải Sáu", 3, 4));
            listXoSo.Add(new infoXoSo("Giải Năm", 1, 5));
            listXoSo.Add(new infoXoSo("Giải Tư", 7, 5));
            listXoSo.Add(new infoXoSo("Giải Ba", 2, 6));
            listXoSo.Add(new infoXoSo("Giải Nhì", 1, 6));
            listXoSo.Add(new infoXoSo("Giải Nhất", 1, 6));
            listXoSo.Add(new infoXoSo("Giải Đặc Biệt", 1, 6));
        }

        public void loadGiaiThuong()
        {
            listGiaiThuong.Add(100000);
            listGiaiThuong.Add(500000);
            listGiaiThuong.Add(1000000);
            listGiaiThuong.Add(2000000);
            listGiaiThuong.Add(5000000);
            listGiaiThuong.Add(10000000);
            listGiaiThuong.Add(50000000);
            listGiaiThuong.Add(100000000);
            listGiaiThuong.Add(1000000000);

            listGiaiThuong.ForEach(x =>
            {
                cbbTrungThuong.Items.Add(x);
            });
        }

        private void setListTextBox()
        {
            listTextBox.Add(tbGiaiTam);
            listTextBox.Add(tbGiaiBay);
            listTextBox.Add(tbGiaiSau);
            listTextBox.Add(tbGiaiNam);
            listTextBox.Add(tbGiaiBon);
            listTextBox.Add(tbGiaiBa);
            listTextBox.Add(tbGiaiNhi);
            listTextBox.Add(tbGiaiNhat);
            listTextBox.Add(tbGiaiDacBiet);

        }

        private void frmXoSo_Load(object sender, EventArgs e)
        {

        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbGiaiDB_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaiNhat_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaiNhi_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaiBa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void cbbGiaiThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTrungThuong.SelectedValue = (int)cbbGiaiThuong.SelectedIndex;
            ten = cbbGiaiThuong.Text.ToString();
            for (int i = 0; i < listXoSo.Count; i++)
            {
                if (ten.Equals(listXoSo[i].ten))
                {
                    sogiai = listXoSo[i].sogiai;
                    sochuso = listXoSo[i].sochuso;
                    sotien = listGiaiThuong[i];
                    break;
                }
            }
        }

        public void setDate()
        {
            DateTime dateCurrent = DateTime.Today;
            dtNgayQuay.Value = dateCurrent;
        }

        public void loadCbb()
        {
            listXoSo.ForEach(x => {
                cbbGiaiThuong.Items.Add(x.ten);
            });
        }

        private void btnQuayThuong_Click(object sender, EventArgs e)
        {
            if (cbChayToanBo.Checked)
            {
                if(tbXoSo.Text.Length == 0)
                {
                    MessageBox.Show(this, "Vui lòng nhập xổ số dò", "Thông Báo");
                    return;
                }

                btnReset.PerformClick();

                trungthuong = 0;
                cbbGiaiThuong.SelectedIndex = 0;
                cbbTrungThuong.SelectedIndex = 0;
                tb = listTextBox[0];
                sotien = listGiaiThuong[0];
                cbbGiaiThuong.Enabled = false;
                btnQuayThuong.Enabled = false;
                nbSleep.Enabled = false;
                tbXoSo.Enabled = false;
                timerQuayAll.Enabled = true;
                return;
            }
            switch (ten)
            {
                case "Giải Đặc Biệt":
                    tb = tbGiaiDacBiet;
                    break;
                case "Giải Nhất":
                    tb = tbGiaiNhat;
                    break;
                case "Giải Nhì":
                    tb = tbGiaiNhi;
                    break;
                case "Giải Ba":
                    tb = tbGiaiBa;
                    break;
                case "Giải Tư":
                    tb = tbGiaiBon;
                    break;
                case "Giải Năm":
                    tb = tbGiaiNam;
                    break;
                case "Giải Sáu":
                    tb = tbGiaiSau;
                    break;
                case "Giải Bảy":
                    tb = tbGiaiBay;
                    break;
                case "Giải Tám":
                    tb = tbGiaiTam;
                    break;
                default:
                    MessageBox.Show(this, "Vui lòng chọn giải để quay", "Thông Báo");
                    break;
            }

            if (tb != null)
            {
                quayXoSo(timerQuay);
            }
        }

        public void quayXoSo(System.Windows.Forms.Timer timer)
        {
            sleepOneLoop = totalSleep / sogiai;

            nbSleep.Enabled = false;
            btnQuayThuong.Enabled = false;

            string[] split = tb.Text.Split(' ');
            if (split.Length > sogiai)
                tb.Text = "";
            timer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string number = "";
            for (int i = 0; i < sochuso; i++)
                number += (rd.Next(10) + "");
            lbQuayThuong.Text = number;
            timeout += timerQuay.Interval;

            if (timeout >= sleepOneLoop)
            {
                tb.Text += lbQuayThuong.Text + " ";
                countLoop++;
                timeout = 0;
                if (countLoop >= sogiai)
                {
                    countLoop = 0;
                    nbSleep.Enabled = true;
                    btnQuayThuong.Enabled = true;
                    timerQuay.Enabled = false;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbGiaiBa.ResetText();
            tbGiaiBay.ResetText();
            tbGiaiTam.ResetText();
            tbGiaiSau.ResetText();
            tbGiaiNam.ResetText();
            tbGiaiBon.ResetText();
            tbGiaiNhat.ResetText();
            tbGiaiNhi.ResetText();
            tbGiaiDacBiet.ResetText();
        }

        private void cbChayToanBo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerQuayAll_Tick(object sender, EventArgs e)
        {
            string number = "";
            for (int i = 0; i < sochuso; i++)
                number += (rd.Next(10) + "");
            lbQuayThuong.Text = number;
            timeout += timerQuay.Interval;

            if (timeout >= totalSleep)
            {
                /* if (sochuso == 3)
                     lbQuayThuong.Text = "748";*/
                if (ten == "Giải Đặc Biệt")
                    lbQuayThuong.Text = "054839";
                tb.Text += lbQuayThuong.Text + " ";
                if (lbQuayThuong.Text.Trim().Equals(tbXoSo.Text.Trim().Substring(Math.Abs(lbQuayThuong.Text.Trim().Length - 6))))
                {
                    trungthuong += sotien;
                }
                countLoop++;
                timeout = 0;
                if (countLoop >= sogiai)
                {
                    countLoop = 0;
                    indexLoop++;
                    if(indexLoop < 9)
                    {
                        sotien = listGiaiThuong[indexLoop];
                        cbbGiaiThuong.SelectedIndex = indexLoop;
                        cbbTrungThuong.SelectedIndex = indexLoop;
                        tb = listTextBox[indexLoop];
                    }
                }
                if (indexLoop >= 9)
                {
                    countLoop = 0;
                    indexLoop = 0;
                    cbbGiaiThuong.Enabled = true;
                    btnQuayThuong.Enabled = true;
                    nbSleep.Enabled = true;
                    tbXoSo.Enabled = true;
                    timerQuayAll.Enabled = false;
                    MessageBox.Show(this, "Chúc mừng bạn đã trúng thưởng: " + trungthuong, "Xin Chúc Mừng");
                }
            }
        }

        private void lbQuayThuong_Click(object sender, EventArgs e)
        {

        }

        private void nbSleep_ValueChanged(object sender, EventArgs e)
        {
            totalSleep = Convert.ToInt32(nbSleep.Value) * 1000;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
