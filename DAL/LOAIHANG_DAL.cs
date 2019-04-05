using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public  class LOAIHANG_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable LoaiHang_select()
        {
            return thaotac.SQL_LayDuLieu("select_loaihang");
        }
        public DataTable LoaiHang_select_codk(string MaLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            return thaotac.SQL_LayDuLieu_codk("select_loaihang_codk",name,value,1);
        }
        public int LoaiHang_insert(string MaLH,string TenLH,string ghichu)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            name[1] = "@TenLoaiHang"; value[1] = TenLH;
            name[2] = "@GhiChu"; value[2] = ghichu;
            return thaotac.sQL_thuchien("insert_loaihang",name,value,3);
        }
        public int LoaiHang_update(string MaLH, string TenLH, string ghichu)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            name[1] = "@TenLoaiHang"; value[1] = TenLH;
            name[2] = "@GhiChu"; value[2] = ghichu;
            return thaotac.sQL_thuchien("update_loaihang", name, value, 3);
        }
        public int LoaiHang_delete(string MaLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
        
            return thaotac.sQL_thuchien("delete_loaihang", name, value, 1);
        }
  
    }
}
