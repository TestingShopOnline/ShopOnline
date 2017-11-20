using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHangEntity;
using QuanLyBanHangBUS;

namespace QLBH11
{
    public partial class frmXemHD : Form
    {
        public frmXemHD()
        {
            InitializeComponent();
        }
        BUS_tblHoaDon bus = new BUS_tblHoaDon();
        ECtblHoaDon ec = new ECtblHoaDon();
        bool themmoi;


        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtNgay.Enabled = false;
            txtKH.Enabled = false;
            txtNV.Enabled = false;
            


            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtNgay.Enabled = true;
            txtKH.Enabled = true;
            txtNV.Enabled = true;
            

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtNgay.Text = "";
            txtKH.Text = "";
            txtNV.Text = "";

        }
        void HienThi(string where)
        {
            msds.DataSource = bus.LayDuLieu(where);
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
                ec.MaHD = txtMa.Text;
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
            if (txtMa.Text == "" || txtNgay.Text == "" || txtKH.Text == "" )
            {
                MessageBox.Show("nhap TT");
                return;
            }
            if (themmoi == true)
            {
                try
                {

                    ec.MaHD = txtMa.Text;
                    ec.NgayLap = txtNgay.Text;
                    ec.MaKH= txtKH.Text;
                    ec.MaNV = txtNV.Text;
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
                    ec.MaHD = txtMa.Text;
                    ec.NgayLap = txtNgay.Text;
                    ec.MaKH = txtKH.Text;
                    ec.MaNV = txtNV.Text;
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
                txtNgay.Text = msds.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtKH.Text = msds.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNV.Text = msds.Rows[e.RowIndex].Cells[3].Value.ToString();
             
             

            }
            catch
            {

            }
        }

        private void frmXemHD_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dk = new Form1();
            dk.ShowDialog();
        }
   
    }
}
