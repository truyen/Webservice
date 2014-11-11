using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDonHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceDonHang
    {
       
        
        [OperationContract]
        List<DonHang> findAll();

        [OperationContract]
        DonHang find(int id);

        [OperationContract]
        bool insert(DateTime ngay, int tongtien, bool dagiaohang, bool active, string kh_ten, string kh_diachi, string kh_email, string kh_sodt);

        [OperationContract]
        bool delete(int id);

        [OperationContract]
        bool update(int id, DateTime ngay, int tongtien, bool dagiaohang, bool active, string kh_ten, string kh_diachi, string kh_email, string kh_sodt);
    }
}
