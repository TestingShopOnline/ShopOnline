using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHangBUS;
using QuanLyBanHangDAL;
using QuanLyBanHangEntity;

namespace QLBH11
{
    public partial class frmHang : Form
    {
        public frmHang()
        {
            InitializeComponent();
        }
        BUS_tblHang bus = new BUS_tblHang();
        ECtblHang ec = new ECtblHang();
        bool themmoi;


        void KhoaDieuKhien()
        {
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtDVT.Enabled = false;
            txtDG.Enabled = false;
            txtSL.Enabled = false;
            txtNhaSX.Enabled = false;
            txtMoTa.Enabled = false;
            

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtMaHang.Enabled = true;
            txtTenHang.Enabled = true;
            txtDVT.Enabled = true;
            txtDG.Enabled = true;
            txtSL.Enabled = true;
            txtNhaSX.Enabled = true;
            txtMoTa.Enabled = true;
            

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void SetNull()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtDVT.Text = "";
            txtDG.Text = "";
            
        }
        void HienThi(string where)
        {
            msds1.DataSource = bus.TaoBang(where);
        }





       

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            themmoi = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaHang.Enabled = false;
            themmoi = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaHang = txtMaHang.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Da xoa");
                KhoaDieuKhien();
                SetNull();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("loi khong xoa duoc");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || txtDG.Text == "" || txtDVT.Text == "" || txtMoTa.Text =="" || txtNhaSX.Text=="" || txtSL.Text == "")
            {
                MessageBox.Show("nhap TT");
                return;
            }
            if (themmoi == true)
            {
                try
                {

                    ec.MaHang = txtMaHang.Text;
                    ec.TenHang = txtTenHang.Text;
                    ec.DVT = txtDVT.Text;
                    ec.DonGia = txtDG.Text;
                    ec.NhaSX = txtNhaSX.Text;
                    ec.SoLuongCon = txtSL.Text;
                    ec.MoTa = txtMoTa.Text;
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("da luu");
                }
                catch
                {
                    MessageBox.Show("Loi");
                    return;
                }


            }
            else
            {
                try
                {
                    ec.MaHang = txtMaHang.Text;
                    ec.TenHang = txtTenHang.Text;
                    ec.DVT = txtDVT.Text;
                    ec.DonGia = txtDG.Text;
                    ec.NhaSX = txtNhaSX.Text;
                    ec.SoLuongCon = txtSL.Text;
                    ec.MoTa = txtMoTa.Text;
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("da luu");

                }
                catch
                {
                    MessageBox.Show("hoan tat");
                    return;
                }

            }
            SetNull();
            KhoaDieuKhien();
            HienThi("");

        }

        private void msds1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {

                txtMaHang.Text = msds1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenHang.Text = msds1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDG.Text = msds1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDVT.Text = msds1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNhaSX.Text = msds1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSL.Text = msds1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMoTa.Text = msds1.Rows[e.RowIndex].Cells[7].Value.ToString();
             

            }
            catch
            {

            }
        }

        private void frmHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 dk = new Form1();
            dk.ShowDialog();
        }
    }
}
