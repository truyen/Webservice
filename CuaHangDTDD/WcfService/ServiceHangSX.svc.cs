using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceHangSX" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceHangSX.svc or ServiceHangSX.svc.cs at the Solution Explorer and start debugging.
    public class ServiceHangSX : IServiceHangSX
    {
        private DataClassesDataContext dc = new DataClassesDataContext();

        public List<HangSX> findAll()
        {
            return this.dc.HangSXes.ToList();
        }

        public HangSX find(int id)
        {
            return this.dc.HangSXes.Single(h => h.id == id); 
        }

        public bool insert(string ten, bool active)
        {
            try
            {
                HangSX hang = new HangSX();
                hang.ten = ten;
                hang.active = active;
                dc.HangSXes.InsertOnSubmit(hang);
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
                HangSX hang = dc.HangSXes.Single(h => h.id == id);
                dc.HangSXes.DeleteOnSubmit(hang);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool update(int id, string ten, bool active)
        {
            try
            {
                HangSX hang = dc.HangSXes.Single(h => h.id == id);
                hang.ten = ten;
                hang.active = true;
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
