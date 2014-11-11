using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChiTietDonHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceChiTietDonHang.svc or ServiceChiTietDonHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceChiTietDonHang : IServiceChiTietDonHang
    {
        private DataClassesDataContext dc = new DataClassesDataContext();
        public List<ChiTiet_DonHang> findAll()
        {
            return this.dc.ChiTiet_DonHangs.ToList();
        }

        public ChiTiet_DonHang find(int id)
        {
            return this.dc.ChiTiet_DonHangs.Single(h => h.id == id);
        }
        public bool insert(int soluong, int dongia, int donhang_id, int sanpham_chitiet_id)
        {
            try
            {
                ChiTiet_DonHang ctdh = new ChiTiet_DonHang();
                ctdh.soluong = soluong;
                ctdh.dongia = dongia;
                ctdh.donhang_id = donhang_id;
                ctdh.sanpham_chitiet_id = sanpham_chitiet_id;
                dc.ChiTiet_DonHangs.InsertOnSubmit(ctdh);
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
                ChiTiet_DonHang ctdh = dc.ChiTiet_DonHangs.Single(ctdhs => ctdhs.id == id);
                dc.ChiTiet_DonHangs.DeleteOnSubmit(ctdh);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool update(int id, int soluong, int dongia, int donhang_id, int sanpham_chitiet_id)
        {
            try
            {
                ChiTiet_DonHang ctdh = dc.ChiTiet_DonHangs.Single(ctdhs => ctdhs.id == id);
                ctdh.soluong = soluong;
                ctdh.dongia = dongia;
                ctdh.donhang_id = donhang_id;
                ctdh.sanpham_chitiet_id = sanpham_chitiet_id;
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
