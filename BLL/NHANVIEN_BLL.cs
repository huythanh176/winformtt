using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NHANVIEN_BLL
    {
        NHANVIEN_DAL nvdal = new NHANVIEN_DAL();
        public DataTable nv_select()
        {
            return nvdal.nhanvien_select();
        }
        public DataTable nv_select_codk(string MaNV)
        {
            return nvdal.nhanvien_select_codk(MaNV);
        }
        public int nv_insert(string MaNV, string TenNV, DateTime NgaySinh, bool gioitinh, string SDT)
        {
            return nvdal.nhanvien_insert(MaNV, TenNV, NgaySinh, gioitinh, SDT);
        }
        public int nv_update(string MaNV, string TenNV, DateTime NgaySinh, bool gioitinh, string SDT)
        {
            return nvdal.nhanvien_update(MaNV, TenNV, NgaySinh, gioitinh, SDT);
        }
        public int nv_delete(string MaNV)
        {
            return nvdal.nhanvien_delete(MaNV);
        }
    }
}
