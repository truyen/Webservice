using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChiTietNhapHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceChiTietNhapHang.svc or ServiceChiTietNhapHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceChiTietNhapHang : IServiceChiTietNhapHang
    {
        private DataClassesDataContext dc = new DataClassesDataContext();
        public List<ChiTiet_NhapHang> findAll()
        {
            return this.dc.ChiTiet_NhapHangs.ToList();
        }

        public ChiTiet_NhapHang find(int id)
        {
            return this.dc.ChiTiet_NhapHangs.Single(h => h.id == id);
        }
        public bool insert(int soluong, int dongia, int nhaphang_id, int sanpham_chitiet_id)
        {
            try
            {
                ChiTiet_NhapHang ctnh = new ChiTiet_NhapHang();
                ctnh.soluong = soluong;
                ctnh.dongia = dongia;
                ctnh.nhaphang_id = nhaphang_id;
                ctnh.sanpham_chitiet_id = sanpham_chitiet_id;
                dc.ChiTiet_NhapHangs.InsertOnSubmit(ctnh);
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
                ChiTiet_NhapHang ctnh = dc.ChiTiet_NhapHangs.Single(ctnhs => ctnhs.id == id);
                dc.ChiTiet_NhapHangs.DeleteOnSubmit(ctnh);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool update(int id, int soluong, int dongia, int nhaphang_id, int sanpham_chitiet_id)
        {
            try
            {
                ChiTiet_NhapHang ctnh = dc.ChiTiet_NhapHangs.Single(ctnhs => ctnhs.id == id);
                ctnh.soluong = soluong;
                ctnh.dongia = dongia;
                ctnh.nhaphang_id = nhaphang_id;
                ctnh.sanpham_chitiet_id = sanpham_chitiet_id;
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
