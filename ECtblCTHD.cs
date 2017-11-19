using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangEntity
{
    public class ECtblCTHD
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private string _MaHang;

        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }
        private string _SoLuongMua;

        public string SoLuongMua
        {
            get { return _SoLuongMua; }
            set { _SoLuongMua = value; }
        }
        private string _DonGia;

        public string DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private string _ThanhTien;

        public string ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
    }
}
