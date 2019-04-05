using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class LOAIHANG_BLL
    {
        LOAIHANG_DAL lhdav = new LOAIHANG_DAL();
        public DataTable lh_select()
        {
            return lhdav.LoaiHang_select();
        }
        public DataTable lh_select_codk(string MaLH)
        {
            return lhdav.LoaiHang_select_codk(MaLH);
        }
        public int lh_insert(string MaLH, string TenLH, string ghichu)
        {
            return lhdav.LoaiHang_insert( MaLH,  TenLH,ghichu);
        }
        public int lh_update(string MaLH, string TenLH, string ghichu)
        {
            return lhdav.LoaiHang_update(MaLH, TenLH, ghichu);
        }
        public int lh_delete(string MaLH)
        {
            return lhdav.LoaiHang_delete(MaLH);
        }
    }
}
