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
    public class BUS_tblCTHD
    {
        SQL_tblCTHD sql = new SQL_tblCTHD();
        public int KiemTra(string mahd, string mahang)
        {
            return sql.KiemTra(mahd, mahang);
        }

        public void ThemDuLieu(ECtblCTHD et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(ECtblCTHD et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(ECtblCTHD et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }

        public DataTable LayTTH(string DieuKien)
        {
            return sql.LayTTH(DieuKien);
        }
        
    }
}
