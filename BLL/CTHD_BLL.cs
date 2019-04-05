using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class CTHD_BLL
    {
        CTHD_DAL cthddav = new CTHD_DAL();
        public DataTable CTHD_select()
        {
            return cthddav.CTHD_select();
        }
        public DataTable CTHD_select_codk(string MaHD)
        {
            return cthddav.CTHD_select_codk( MaHD);
        }
        public DataTable CTHD_select_secle(string MaHD)
        {
            return cthddav.CTHD_select_secle(MaHD);
        }
        public int CTHD_insert(string MaHD, string MaLoaiHang, int SL)
        {
            return cthddav.CTHD_insert(MaHD, MaLoaiHang, SL);
        }
        public int CTHD_update(string MaHD, string MaLoaiHang, int SL)
        {
            return cthddav.CTHD_update(MaHD, MaLoaiHang, SL);
        }
        public int CTHD_delete(string MaHD)
        {
            return cthddav.CTHD_delete(MaHD);
        }
    }
}
