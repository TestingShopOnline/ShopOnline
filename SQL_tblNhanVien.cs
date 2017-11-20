using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangEntity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHangDAL
{
    public class SQL_tblNhanVien
    {
        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(ECtblNhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblNhanVien (MaNV, TenNV, DiaChi, DienThoai, TinhTrang, TenDN, MatKhau ) VALUES(N'"+ et.MaNV +"',N'" + et.TenNV + "',N'" + et.DiaChi +"',N'"+ et.DienThoai +"',N'"+ et.TinhTrang +"',N'"+et.TenDN+"','" +et.MatKhau+"')");

        }

        public void SuaDuLieu(ECtblNhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblNhanVien SET TenNV =N'" + et.TenNV + "', DiaChi =N'" + et.DiaChi + "', DienThoai =N'" + et.DienThoai + "', TinhTrang = N'" + et.TinhTrang +"', TenDN ='"+et.TenDN+"', MatKhau ='" +et.MatKhau+"' where MaNV=N'" + et.MaNV+"'");

        }

        public void XoaDuLieu(ECtblNhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from tblNhanVien where MaNV=N'" + et.MaNV + "'");  
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblNhanVien " + DieuKien);
        }

    }
}
