using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSanPhamChiTiet" in both code and config file together.
    [ServiceContract]
    public interface IServiceSanPhamChiTiet
    {

        [OperationContract]
        List<SanPham_ChiTiet> findAll();

        [OperationContract]
        SanPham_ChiTiet find(int id);

        [OperationContract]
        bool insert(Boolean active,int tonkho, int mausac_id,int sanpham_id);

        [OperationContract]
        bool delete(int id);

        [OperationContract]
        bool update(int id, Boolean active, int tonkho, int mausac_id, int sanpham_id);
    }
}
