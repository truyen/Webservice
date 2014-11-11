using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSanPhamChiTiet" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSanPhamChiTiet.svc or ServiceSanPhamChiTiet.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSanPhamChiTiet : IServiceSanPhamChiTiet
    {
        private DataClassesDataContext dc = new DataClassesDataContext();
        public List<SanPham_ChiTiet> findAll()
        {
            return this.dc.SanPham_ChiTiets.ToList();
        }

        public SanPham_ChiTiet find(int id)
        {
            return dc.SanPham_ChiTiets.Single(spct => spct.id == id);
        }

        public bool insert(Boolean active, int tonkho, int mausac_id, int sanpham_id)
        {
            try
            {
                SanPham_ChiTiet spct = new SanPham_ChiTiet();
                
                spct.active = active;
                spct.tonkho = tonkho;
                spct.mausac_id = mausac_id;
                spct.sanpham_id = sanpham_id;
                dc.SanPham_ChiTiets.InsertOnSubmit(spct);
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
                SanPham_ChiTiet spct = dc.SanPham_ChiTiets.Single(spcts => spcts.id == id);
                dc.SanPham_ChiTiets.DeleteOnSubmit(spct);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(int id, Boolean active, int tonkho, int mausac_id, int sanpham_id)
        {

            try
            {
                SanPham_ChiTiet spct = dc.SanPham_ChiTiets.Single(spcts => spcts.id == id);
                spct.active = active;
                spct.tonkho = tonkho;
                spct.mausac_id = mausac_id;
                spct.sanpham_id = sanpham_id;
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
