using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KHACHHANG_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable khachhang_select()
        {
            return thaotac.SQL_LayDuLieu("select_khachhang");
        }
        public DataTable khachhang_select_codk(string MaKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaKH"; value[0] = MaKH;
            return thaotac.SQL_LayDuLieu_codk("select_khachhang_codk", name, value, 1);
        }
        public int khachhang_insert(string MaKH, string TenKH, string DiaChi, string SDT, string STK, string MST)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaKH"; value[0] = MaKH;
            name[1] = "@TenKH"; value[1] = TenKH;
            name[2] = "@DiaChi"; value[2] =DiaChi;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@STK"; value[4] = STK;
            name[5] = "@MST"; value[5] = MST;
            return thaotac.sQL_thuchien("insert_khachhang", name, value, 6);
        }
        public int khachhang_update(string MaKH, string TenKH, string DiaChi, string SDT, string STK, string MST)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaKH"; value[0] = MaKH;
            name[1] = "@TenKH"; value[1] = TenKH;
            name[2] = "@DiaChi"; value[2] = DiaChi;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@STK"; value[4] = STK;
            name[5] = "@MST"; value[5] = MST;
            return thaotac.sQL_thuchien("update_khachhang", name, value, 6);
        }
        public int khachhang_delete(string MaKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaKH"; value[0] = MaKH;

            return thaotac.sQL_thuchien("delete_khachhang", name, value, 1);
        }

    }
}
