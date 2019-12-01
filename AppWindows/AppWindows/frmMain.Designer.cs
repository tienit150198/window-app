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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            frmTinhToan f1 = new frmTinhToan();
            f1.ShowDialog();
        }

        private void btnXoSo_Click(object sender, EventArgs e)
        {
            frmXoSo f2 = new frmXoSo();
            f2.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string text = Form.ActiveForm.Text;
                int len = text.Length;
                string first = text.Substring(0, 1);
                string last = text.Substring(1, len - 1);
                text = last + first;
                Form.ActiveForm.Text = text;
            }
            catch { };


        }

        private Button btnVietLot;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
