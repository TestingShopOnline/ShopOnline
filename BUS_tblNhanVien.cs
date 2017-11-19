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
    public class BUS_tblNhanVien
    {
        SQL_tblNhanVien sql = new SQL_tblNhanVien();

        public void ThemDuLieu(ECtblNhanVien et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(ECtblNhanVien et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(ECtblNhanVien et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }

    }
}
