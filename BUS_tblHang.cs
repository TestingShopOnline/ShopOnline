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
    public class BUS_tblHang
    {
        SQL_tblHang sql = new SQL_tblHang();

        public void ThemDuLieu(ECtblHang et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(ECtblHang et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(ECtblHang et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
      

    }
}
