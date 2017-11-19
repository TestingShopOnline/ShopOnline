using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangEntity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHangDAL
{
    public class SQL_tblHoaDon
    {
        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(ECtblHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHoaDon (MaHD, NgayLap, MaKH, MaNV) VALUES  (N'" + et.MaHD + "',N'" + et.NgayLap + "',N'" + et.MaKH + "',N'" + et.MaNV + "')");
        }
        public void SuaDuLieu(ECtblHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE  tblHoaDon SET NgayLap ='"+et.NgayLap +"', MaKH ='" + et.MaKH +"', MaNV ='" +et.MaNV +"' where MaHD='" +et.MaHD+"'");
        }
        public void XoaDuLieu(ECtblHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from tblHoaDon where MaHD=N'" + et.MaHD + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblHoaDon" + DieuKien);

        }
        public DataTable LayTTKH(string DieuKien)
        {
            return cn.GetDataTable("select MaKH,TenKH from tbtKhachHang " + DieuKien);

        }
        public DataTable LayTTNV(string DieuKien)
        {
            return cn.GetDataTable("select MaNV,TenNV from tblNhanVien " + DieuKien);

        }
    }
}
