using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangEntity
{
    public class ECtblHoaDon
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private string _NgayLap;

        public string NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
    }
}
