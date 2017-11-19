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
    public class BUS_tblKhachHang
    {
        SQL_tblKhachHang sql= new SQL_tblKhachHang();

        public void ThemDuLieu(ECtblKhachHang et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(ECtblKhachHang et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(ECtblKhachHang et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }

    }
}
