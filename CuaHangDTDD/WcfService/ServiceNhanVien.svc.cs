using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceNhanVien" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceNhanVien.svc or ServiceNhanVien.svc.cs at the Solution Explorer and start debugging.
    public class ServiceNhanVien : IServiceNhanVien
    {
        private DataClassesDataContext dc = new DataClassesDataContext();

        public List<NhanVien> findAll()
        {
            return this.dc.NhanViens.ToList();
        }

        public NhanVien find(int id)
        {
            return dc.NhanViens.Single(nv => nv.id == id);
        }

        public bool insert(string ten, string pass, int quyen)
        {
            try
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.ten = ten;
                nhanvien.pass = pass;
                nhanvien.quyen = quyen;
                dc.NhanViens.InsertOnSubmit(nhanvien);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int id)
        {
            try
            {
                NhanVien nhanvien = dc.NhanViens.Single(nv => nv.id == id);
                dc.NhanViens.DeleteOnSubmit(nhanvien);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(int id, string ten, string pass, int quyen)
        {
             try
            {
                NhanVien nhanvien = dc.NhanViens.Single(nv => nv.id == id);
                nhanvien.ten = ten;
                nhanvien.pass = pass;
                nhanvien.quyen = quyen;
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
