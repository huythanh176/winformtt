using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace BLL
{
   public  class HangHoa_BLL
    {
        HANGHOA_DAL hhdav = new HANGHOA_DAL();
        public DataTable hanghoa_select()
        {
            return hhdav.hanghoa_select();
        }
        public DataTable hanghoa_select_codk(string MaHang)
        {
            return hhdav.hanghoa_select_codk(MaHang);
        }
        public DataTable hanghoa_select_codk_mlh(string MaLoaiHang)
        {
            return hhdav.hanghoa_select_codk_mlh(MaLoaiHang);
        }
        public int hh_insert(string MaHang, string TenHang, string DVT, float DonGia, int SLcon, string MaLoaiHang)
        {
            return hhdav.Hanghoa_insert(MaHang, TenHang, DVT, DonGia, SLcon,MaLoaiHang);
        }
        public int hh_update(string MaHang, int SLcon)
        {
            return hhdav.hanghoa_update(MaHang, SLcon);
        }
        public int hh_delete(string MaHang)
        {
            return hhdav.hanghoa_delete(MaHang);
        }
    }
}
