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
    public partial class frmTimKiem : Form
    {
        public bool btnFindClick = false, btnCancelClick = false;
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            btnFindClick = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancelClick = true;
        }
    }
}
