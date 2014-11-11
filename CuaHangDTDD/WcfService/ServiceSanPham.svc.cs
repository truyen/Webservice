using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSanPham" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSanPham.svc or ServiceSanPham.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSanPham : IServiceSanPham
    {
        private DataClassesDataContext dc = new DataClassesDataContext();

        public List<SanPham> findAll()
        {
            return this.dc.SanPhams.ToList();
        }

        public SanPham find(int id)
        {
            return dc.SanPhams.Single(sp => sp.id == id);
        }

        public bool insert(string masp, string ten, string mota, int gia, bool active, int hang_sx)
        {
            try
            {
                SanPham sanpham = new SanPham();
                sanpham.masp = masp;
                sanpham.ten = ten;
                sanpham.mota = mota;
                sanpham.gia = gia;
                sanpham.active = active;
                sanpham.hangsx_id = hang_sx;
                dc.SanPhams.InsertOnSubmit(sanpham);
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
                SanPham sanpham = dc.SanPhams.Single(sp => sp.id == id);
                dc.SanPhams.DeleteOnSubmit(sanpham);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(int id, string masp, string ten, string mota, int gia, bool active, int hang_sx)
        {
            try
            {
                SanPham sanpham = dc.SanPhams.Single(sp => sp.id == id);
                sanpham.masp = masp;
                sanpham.ten = ten;
                sanpham.mota = mota;
                sanpham.gia = gia;
                sanpham.active = active;
                sanpham.hangsx_id = hang_sx;
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
