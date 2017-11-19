using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QuanLyBanHangEntity
{
    public class ECtblNhanVien
    {
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        //private byte[] _HinhAnh;

        //public byte[] HinhAnh
        //{
        //    get { return _HinhAnh; }
        //    set { _HinhAnh = value; }
        //}
       
        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        private string _TenDN;

        public string TenDN
        {
            get { return _TenDN; }
            set { _TenDN = value; }
        }
        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

    }
}
