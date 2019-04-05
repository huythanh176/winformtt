using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HOADON_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable hoadon_select()
        {
            return thaotac.SQL_LayDuLieu("select_hoadon");
        }
        public DataTable select_secle()
        {
            return thaotac.SQL_LayDuLieu("select_secle");
        }
        public DataTable hoadon_select_codk(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_LayDuLieu_codk("select_hoadon_codk", name, value, 1);
        }
        public int hoadon_insert(string MaHD, DateTime NgayHD, string MaNV,string MaKH)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@NgayHD"; value[1] = NgayHD;
            name[2] = "MaNV";value[2] = MaNV;
            name[3] = "MaKH"; value[3] = MaKH;

            return thaotac.sQL_thuchien("insert_hoadon", name, value, 4);
        }
        public int hoadon_update(string MaHD, DateTime NgayHD)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@NgayHD"; value[1] = NgayHD;
            return thaotac.sQL_thuchien("update_hoadon", name, value, 2);
        }
        public int hoadon_delete(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;

            return thaotac.sQL_thuchien("delete_hoadon", name, value, 1);
        }

    }
}
