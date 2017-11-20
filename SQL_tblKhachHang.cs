using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangEntity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHangDAL
{
    public class SQL_tblKhachHang
    {
        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(ECtblKhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblKhachHang (MaKH, TenKH, MaLoaiKH, DiaChi, DienThoai, TinhTrang) VALUES(N'"+ et.MaKH +"',N'" + et.TenKH + "',N'" + et.MaLoaiKH +"',N'"+ et.Diachi +"',N'" + et.DienThoai + "',N'"+ et.TinhTrang +"')");

        }

        public void SuaDuLieu(ECtblKhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblKhachHang SET TenKH =N'" + et.TenKH + "', MaLoaiKH =N'" + et.MaLoaiKH + "', DiaChi =N'" + et.Diachi + "', DienThoai =N'" + et.DienThoai + "', TinhTrang = N'" + et.TinhTrang +"'where MaKH=N'" + et.MaKH+"'");

        }

        public void XoaDuLieu(ECtblKhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from tblKhachHang where MaKH=N'" + et.MaKH + "'");  
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblKhachHang " + DieuKien);

        }
    }
}
