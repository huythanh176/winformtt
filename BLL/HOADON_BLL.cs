using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class HOADON_BLL
    {
        HOADON_DAL hddav = new HOADON_DAL();
        public DataTable hoadon_select()
        {
            return hddav.hoadon_select();
        }
        public DataTable hoadon_select_secle()
        {
            return hddav.select_secle();
        }
        public DataTable hoadon_select_codk(string MaHD)
        {
            return hddav.hoadon_select_codk(MaHD);
        }
        public int hoadon_insert(string MaHD, DateTime NgayHD, string MaNV, string MaKH)
        {
            return hddav.hoadon_insert(MaHD, NgayHD,MaNV,MaKH);
        }
        public int hoadon_update(string MaHD, DateTime NgayHD)
        {
            return hddav.hoadon_update(MaHD, NgayHD);
        }
        public int hoadon_delete(string MaHD)
        {
            return hddav.hoadon_delete(MaHD);
        }
    }
}
