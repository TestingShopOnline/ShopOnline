using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHangBUS;
using QuanLyBanHangEntity;

namespace QLBH11
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        BUS_tblHoaDon bushd = new BUS_tblHoaDon();
        BUS_tblCTHD buscthd = new BUS_tblCTHD();
        int dong = 0;
        //bool themmoi;
        ECtblHoaDon HD = new ECtblHoaDon();
        ECtblCTHD CTHD = new ECtblCTHD();


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            colMa.DataSource = buscthd.LayTTH("where SoLuongCon>0");
            colMa.ValueMember = "MaHang";
            colMa.DisplayMember = "TenHang";
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void msds_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (msds.Rows[dong].Cells[1].Value != "" && msds.Rows[dong].Cells[2].Value != "")
            {
                try
                {
                    msds.Rows[dong].Cells[3].Value = (double.Parse(msds.Rows[dong].Cells[1].Value.ToString()) * double.Parse(msds.Rows[dong].Cells[2].Value.ToString())).ToString();
                }
                catch
                {
                }
            }
            try
            {
                DataTable dt = new DataTable();
                dt = buscthd.LayTTH("where MaHang='" + msds.Rows[dong].Cells[0].Value.ToString() + "'");

                msds.Rows[dong].Cells[2].Value = double.Parse(dt.Rows[0]["DonGiaHang"].ToString());
            }
            catch
            {
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HD.MaHD = txtMa.Text;
            HD.MaKH = txtKH.Text;
            HD.MaNV = txtNV.Text;
            HD.NgayLap = txtNgay.Text;
            try
            {
                bushd.ThemDuLieu(HD);
            }
            catch
            {
            }
            try
            {
                for (int i = 0; i < msds.Rows.Count - 1; i++)
                {
                    CTHD.MaHD = txtMa.Text;
                    CTHD.MaHang = msds.Rows[i].Cells[0].Value.ToString();
                    CTHD.SoLuongMua = msds.Rows[i].Cells[1].Value.ToString();
                    CTHD.DonGia = msds.Rows[i].Cells[2].Value.ToString();
                    buscthd.ThemDuLieu(CTHD);
                }
                MessageBox.Show("Succeed");


            }
            catch { }

        }

        private void btnb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dk = new Form1();
            dk.ShowDialog();
        
        }
    }
}
