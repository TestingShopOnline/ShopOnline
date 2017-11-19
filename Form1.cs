using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLBH11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang m = new frmKhachHang();
            m.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien m = new frmNhanVien();
            m.ShowDialog();
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHang m = new frmHang();
            m.ShowDialog();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDon m = new frmHoaDon();
            m.ShowDialog();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXemHD m = new frmXemHD();
            m.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
