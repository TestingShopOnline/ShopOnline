using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    public class SQL_tblHang
    {
        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(ECtblHang et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHang(MaHang, TenHang, DVT, DonGiaHang, SoLuongCon, NhaSX, MoTa) VALUES ( N'"+ et.MaHang +"',N'" + et.TenHang + "',N'" + et.DVT +"',N'"+ et.DonGia+"',N'" + et.SoLuongCon + "',N'"+ et.NhaSX +"','" + et.MoTa +"')");
        }
        public void SuaDuLieu(ECtblHang et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE  tblHang SET TenHang ='" + et.TenHang + "', DVT ='" + et.DVT + "', DonGiaHang ='" + et.DonGia + "',NhaSX ='" + et.NhaSX + "', SoLuongCon ='" + et.SoLuongCon + "',MoTa='" + et.MoTa + "' where MaHang='" + et.MaHang + "'");
        }
        public void XoaDuLieu(ECtblHang et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from tblHang where MaHang='" + et.MaHang + "'");
        }
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblHang " + DieuKien);

        }
    }
}
