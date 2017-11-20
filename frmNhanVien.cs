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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_tblNhanVien bus = new BUS_tblNhanVien();
        ECtblNhanVien ec = new ECtblNhanVien();
        bool themmoi;


        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDC.Enabled = false;
            txtDT.Enabled = false;
            txtTT.Enabled = false;
            txtDN.Enabled = false;
            txtMK.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtDC.Enabled = true;
            txtDT.Enabled = true;
            txtTT.Enabled = true;
            txtDN.Enabled = true;
            txtMK.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtTT.Text = "";
            txtDN.Text = "";
            txtMK.Text = "";
        }
        void HienThi(string where)
        {
            msds.DataSource = bus.TaoBang(where);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            KhoaDieuKhien();
            HienThi("");
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
            txtMa.Enabled = false;
            themmoi = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaNV = txtMa.Text;
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
            if (txtMa.Text == "" || txtTen.Text == "" || txtDC.Text == "" || txtDT.Text == "" || txtTT.Text == "" || txtDN.Text == "" || txtMK.Text =="")
            {
                MessageBox.Show("nhap TT");
                return;
            }
            if (themmoi == true)
            {
                try
                {

                    ec.MaNV = txtMa.Text;
                    ec.TenNV = txtTen.Text;
                    ec.DiaChi = txtDC.Text;
                    ec.DienThoai = txtDT.Text;
                    ec.TinhTrang = txtTT.Text;
                    ec.TenDN = txtDN.Text;
                    ec.MatKhau = txtMK.Text;
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
                    ec.MaNV = txtMa.Text;
                    ec.TenNV = txtTen.Text;
                    ec.DiaChi = txtDC.Text;
                    ec.DienThoai = txtDT.Text;
                    ec.TinhTrang = txtTT.Text;
                    ec.TenDN = txtDN.Text;
                    ec.MatKhau = txtMK.Text;
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

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {

                txtMa.Text = msds.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = msds.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDC.Text = msds.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDT.Text = msds.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTT.Text = msds.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDN.Text = msds.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMK.Text = msds.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dk = new Form1();
            dk.ShowDialog();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");
        }
    }
}
