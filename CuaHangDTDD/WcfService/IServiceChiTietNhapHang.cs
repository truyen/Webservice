using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceChiTietNhapHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceChiTietNhapHang
    {
        [OperationContract]
        List<ChiTiet_NhapHang> findAll();

        [OperationContract]
        ChiTiet_NhapHang find(int id);

        [OperationContract]
        bool insert(int soluong, int dongia, int nhaphang_id, int sanpham_chitiet_id);

        [OperationContract]
        bool delete(int id);

        [OperationContract]
        bool update(int id, int soluong, int dongia, int nhaphang_id, int sanpham_chitiet_id);
    }
}
