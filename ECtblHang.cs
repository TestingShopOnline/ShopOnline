using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QuanLyBanHangEntity
{
    public class ECtblHang
    {
        private string _MaHang;

        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }
        private string _TenHang;

        public string TenHang
        {
            get { return _TenHang; }
            set { _TenHang = value; }
        }
        private string _DVT;

        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        private string _DonGia;

        public string DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private string _NhaSX;

        public string NhaSX
        {
            get { return _NhaSX; }
            set { _NhaSX = value; }
        }
        private string _SoLuongCon;

        public string SoLuongCon
        {
            get { return _SoLuongCon; }
            set { _SoLuongCon = value; }
        }
        private string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        private byte[] _HinhAnh;

        public byte[] HinhAnh
        {
            get { return _HinhAnh; }
            set { _HinhAnh = value; }
        }
    }

}
