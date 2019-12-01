using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows
{
    public partial class frmTinhToan : Form
    {
        public frmTinhToan()
        {
            InitializeComponent();
        }

        private void frmTinhToan_Load(object sender, EventArgs e)
        {

        }

        private bool checkTextBox()
        {
            if (tbA.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá trị A", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbA.Focus();
                return false;
            }
            else if (tbB.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá trị B", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbB.Focus();
                return false;
            }
            else if (tbA.Text.Contains(".") || tbB.Text.Contains("."))
            {
                MessageBox.Show("Vui lòng nhập giá trị là số nguyên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int convertStringToInt(String text)
        {
            try
            {
                return Int32.Parse(text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập giá trị là số nguyên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Int32.MaxValue;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(checkTextBox() == true)
            {
                int numA = convertStringToInt(tbA.Text.ToString());
                int numB = convertStringToInt(tbB.Text.ToString());

                if(numA != Int32.MaxValue && numB != Int32.MaxValue)
                {
                    int result = numA + numB;
                    tbKetQua.Text = ("" + result);
                }
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (checkTextBox() == true)
            {
                int numA = convertStringToInt(tbA.Text.ToString());
                int numB = convertStringToInt(tbB.Text.ToString());

                if (numA != Int32.MaxValue && numB != Int32.MaxValue)
                {
                    int result = numA - numB;
                    tbKetQua.Text = ("" + result);
                }
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkTextBox() == true)
            {
                int numA = convertStringToInt(tbA.Text.ToString());
                int numB = convertStringToInt(tbB.Text.ToString());

                if (numA != Int32.MaxValue && numB != Int32.MaxValue)
                {
                    int result = numA * numB;
                    tbKetQua.Text = ("" + result);
                }
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (checkTextBox() == true)
            {
                int numA = convertStringToInt(tbA.Text.ToString());
                int numB = convertStringToInt(tbB.Text.ToString());

                if (numA != Int32.MaxValue && numB != Int32.MaxValue)
                {
                    double resultDiv = numA /(double)numB;
                    tbKetQua.Text = resultDiv.ToString();
                }
            }
        }
    }
}
