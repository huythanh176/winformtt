using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HANGHOA_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable hanghoa_select()
        {
            return thaotac.SQL_LayDuLieu("select_hanghoa");
        }
        public DataTable hanghoa_select_codk(string MaHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = MaHang;
            return thaotac.SQL_LayDuLieu_codk("select_hanghoa_codk", name, value, 1);
        }
        public DataTable hanghoa_select_codk_mlh(string MaHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = MaHang;
            return thaotac.SQL_LayDuLieu_codk("select_hanghoa_codk_mlh", name, value, 1);
        }
        public int Hanghoa_insert(string MaHang, string TenHang, string DVT,float DonGia,int SLcon, string MaLoaiHang)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaHang"; value[0] = MaHang;
            name[1] = "@TenHang"; value[1] = TenHang;
            name[2] = "@DVT"; value[2] = DVT;
            name[3] = "@DonGia"; value[3] = DonGia;
            name[4] = "@SLcon"; value[4] = SLcon;
            name[5] = "@MaLoaiHang"; value[5] = MaLoaiHang;
            return thaotac.sQL_thuchien("insert_hanghoa", name, value, 6);
        }
        public int hanghoa_update(string MaHang, int SLcon)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHang"; value[0] = MaHang;
        
            name[1] = "@SLcon"; value[1] = SLcon;
            return thaotac.sQL_thuchien("update_hanghoa", name, value, 2);
        }
        public int hanghoa_delete(string MaHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = MaHang;

            return thaotac.sQL_thuchien("delete_hanghoa", name, value, 1);
        }

    }
}
