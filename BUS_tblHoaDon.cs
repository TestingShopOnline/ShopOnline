using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanHangEntity;
using System.Data.SqlClient;
using QuanLyBanHangDAL;

namespace QuanLyBanHangBUS
{
    public class BUS_tblHoaDon
    {
        SQL_tblHoaDon sql = new SQL_tblHoaDon();

        public void ThemDuLieu(ECtblHoaDon et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(ECtblHoaDon et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(ECtblHoaDon et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable LayTTKH(string DieuKien)
        {
            return sql.LayTTKH(DieuKien);
        }
        public DataTable LayTTNV(string DieuKien)
        {
            return sql.LayTTNV(DieuKien);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }


    }
}
