using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDonHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDonHang.svc or ServiceDonHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDonHang : IServiceDonHang
    {
  
         

        private DataClassesDataContext dc = new DataClassesDataContext();

        public List<DonHang> findAll()
        {
            return this.dc.DonHangs.ToList();
        }

        public DonHang find(int id)
        {
            return dc.DonHangs.Single(dh => dh.id == id);
        }

        public bool insert(DateTime ngay, int tongtien, bool dagiaohang, bool active, string kh_ten, string kh_diachi, string kh_email, string kh_sodt)
        {
            try
            {
                DonHang donhang = new DonHang();
                donhang.ngay = ngay;
                donhang.tongtien = tongtien;
                donhang.dagiaohang = dagiaohang;
                donhang.active = active;
                donhang.kh_ten = kh_ten;
                donhang.kh_diachi = kh_diachi;
                donhang.kh_email = kh_email;
                dc.DonHangs.InsertOnSubmit(donhang);
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
                DonHang donhang = dc.DonHangs.Single(dh => dh.id == id);
                dc.DonHangs.DeleteOnSubmit(donhang);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(int id, DateTime ngay, int tongtien, bool dagiaohang, bool active, string kh_ten, string kh_diachi, string kh_email, string kh_sodt)
        {
            try
            {
                DonHang donhang = dc.DonHangs.Single(dh => dh.id == id);
                donhang.ngay = ngay;
                donhang.tongtien = tongtien;
                donhang.dagiaohang = dagiaohang;
                donhang.active = active;
                donhang.kh_ten = kh_ten;
                donhang.kh_diachi = kh_diachi;
                donhang.kh_email = kh_email;
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
