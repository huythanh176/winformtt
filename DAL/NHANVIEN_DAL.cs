using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable nhanvien_select()
        {
            return thaotac.SQL_LayDuLieu("select_nhanvien");
        }
        public DataTable nhanvien_select_codk(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;
            return thaotac.SQL_LayDuLieu_codk("select_nhanvien_codk", name, value, 1);
        }
        public int nhanvien_insert(string MaNV, string TenNV, DateTime NgaySinh,bool gioitinh, string SDT)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@TenNV"; value[1] = TenNV;
            name[2] = "@NgaySinh"; value[2] = NgaySinh;
            name[3] = "@gioitinh"; value[3] = gioitinh;
            name[4] = "@SDT"; value[4] = SDT;
        
            return thaotac.sQL_thuchien("insert_nhanvien", name, value, 5);
        }
        public int nhanvien_update(string MaNV, string TenNV, DateTime NgaySinh, bool gioitinh, string SDT)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@TenNV"; value[1] = TenNV;
            name[2] = "@NgaySinh"; value[2] = NgaySinh;
            name[3] = "@gioitinh"; value[3] = gioitinh;
            name[4] = "@SDT"; value[4] = SDT;

            return thaotac.sQL_thuchien("update_nhanvien", name, value, 5);
        }
        public int nhanvien_delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;

            return thaotac.sQL_thuchien("delete_nhanvien", name, value, 1);
        }
    }
}
