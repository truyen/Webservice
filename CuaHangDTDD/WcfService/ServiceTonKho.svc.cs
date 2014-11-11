using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTonKho" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTonKho.svc or ServiceTonKho.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTonKho : IServiceTonKho
    {
        private DataClassesDataContext dc = new DataClassesDataContext();
        public List<TonKhoe> findAll()
        {
            return this.dc.TonKhoes.ToList();
        }

        public TonKhoe find(int id)
        {
            return dc.TonKhoes.Single(tk => tk.id == id);
        }

        public bool insert(int soluong, DateTime ngay, int sanpham_chitiet_id)
        {
            try
            {
                TonKhoe tonkho = new TonKhoe();
                tonkho.soluong = soluong;
                tonkho.ngay = ngay;
                tonkho.sanpham_chitiet_id = sanpham_chitiet_id;
                dc.TonKhoes.InsertOnSubmit(tonkho);
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
                TonKhoe tonkho = dc.TonKhoes.Single(tk => tk.id == id);
                dc.TonKhoes.DeleteOnSubmit(tonkho);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(int id, int soluong, DateTime ngay, int sanpham_chitiet_id)
        {

            try
            {
                TonKhoe tonkho = dc.TonKhoes.Single(tk => tk.id == id);
                tonkho.soluong = soluong;
                tonkho.ngay = ngay;
                tonkho.sanpham_chitiet_id = sanpham_chitiet_id;
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
