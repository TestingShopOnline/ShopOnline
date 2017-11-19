using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangEntity;
using System.Data;
using QuanLyBanHangDAL;

namespace QuanLyBanHangDAL
{
    public class SQL_tblCTHD
    {
        KetNoiDB cn = new KetNoiDB();

        public int KiemTra(string mahd, string mahang)
        {
            return int.Parse(cn.GetValue("select count(*) from tblCTHD where MaHD='"+mahd+"'and MaHang='"+mahang+"'"));
        }

        public void ThemDuLieu(ECtblCTHD et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblCTHD (MaHD, MaHang, SoLuongMua, DonGia, ThanhTien ) VALUES  (N'" + et.MaHD + "',N'" + et.MaHang + "',N'" + et.SoLuongMua + "',N'" + et.DonGia + "',(" +et.SoLuongMua+" * "+et.DonGia+"))");
        }
        public void SuaDuLieu(ECtblCTHD et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE  tblCTHD SET SoLuongMua = '" + et.SoLuongMua + "', DonGia = '" + et.DonGia + "', ThanhTien = (" + et.SoLuongMua + "*" + et.DonGia + ") where MaHD='"+et.MaHD+"' And MaHang='"+et.MaHang+"'");
        }
        public void XoaDuLieu(ECtblCTHD et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from tblCTHD where MaHD='" + et.MaHD + "' And MaHang='" + et.MaHang + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable(@"Select * from tblCTHD" + DieuKien);

        }
        public DataTable LayTTH(string DieuKien)
        {
            return cn.GetDataTable(@"Select MaHang,TenHang,DonGiaHang from tblHang " + DieuKien);

        }
    }
}
