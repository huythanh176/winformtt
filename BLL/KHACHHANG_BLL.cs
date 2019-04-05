using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class KHACHHANG_BLL
    {
        KHACHHANG_DAL khdav = new KHACHHANG_DAL();
        public DataTable kh_select()
        {
            return khdav.khachhang_select();
        }
        public DataTable kh_select_codk(string MaKH)
        {
            return khdav.khachhang_select_codk(MaKH);
        }
        public int kh_insert(string MaKH, string TenKH, string DiaChi, string SDT, string STK, string MST)
        {
            return khdav.khachhang_insert(MaKH, TenKH, DiaChi, SDT, STK, MST);
        }
        public int kh_update(string MaKH, string TenKH, string DiaChi, string SDT, string STK, string MST)
        {
            return khdav.khachhang_update(MaKH, TenKH, DiaChi, SDT, STK, MST);
        }
        public int kh_delete(string MaKH)
        {
            return khdav.khachhang_delete(MaKH);
        }
    }
}
