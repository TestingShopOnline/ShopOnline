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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BUS_tblKhachHang bus = new BUS_tblKhachHang();
        ECtblKhachHang ec = new ECtblKhachHang();
        bool themmoi;


        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cbLoai.Enabled = false;
            txtDC.Enabled = false;
            txtDT.Enabled = false;
            

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            cbLoai.Enabled = true;
            txtDC.Enabled = true;
            txtDT.Enabled = true;
            

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            cbLoai.Text = "normal";
            txtDC.Text = "";
            txtDT.Text = "";
            
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
                ec.MaKH = txtMa.Text;
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
            if (txtMa.Text == "" || txtTen.Text == "" || txtDT.Text == "" || txtDC.Text == "" || cbLoai.Text == "")
            {
                MessageBox.Show("nhap TT");
                return;
            }
            if (themmoi == true)
            {
                try
                {

                    ec.MaKH = txtMa.Text;
                    ec.TenKH = txtTen.Text;
                    ec.MaLoaiKH = cbLoai.Text;
                    ec.Diachi = txtDC.Text;
                    ec.DienThoai = txtDT.Text;
                    ec.TinhTrang = "true";
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
                    ec.MaKH = txtMa.Text;
                    ec.TenKH = txtTen.Text;
                    ec.MaLoaiKH = cbLoai.Text;
                    ec.Diachi = txtDC.Text;
                    ec.DienThoai = txtDT.Text;
                    ec.TinhTrang = "true";
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
                txtDT.Text = msds.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDC.Text = msds.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbLoai.Text = msds.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dk = new Form1();
            dk.ShowDialog();
        }
    }
}
