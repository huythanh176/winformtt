using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTHD_DAL
    {

        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable CTHD_select()
        {
            return thaotac.SQL_LayDuLieu("select_ctdh");
        }
        public DataTable CTHD_select_codk(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_LayDuLieu_codk("select_cthd_codk", name, value, 1);
        }
        public DataTable CTHD_select_secle(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_LayDuLieu_codk("select_ctdh_secle", name, value, 1);
        }
        public int CTHD_insert(string MaHD, string MaLoaiHang, int SL)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaLoaiHang;
            name[2] = "@SL"; value[2] = SL;
            return thaotac.sQL_thuchien("insert_cthd", name, value, 3);
        }
        public int CTHD_update(string MaHD, string MaLoaiHang, int SL)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaLoaiHang;
            name[2] = "@SL"; value[2] = SL;
            return thaotac.sQL_thuchien("update_cthd", name, value, 3);
        }
        public int CTHD_delete(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;

            return thaotac.sQL_thuchien("delete_cthd", name, value, 1);
        }

    }
}

