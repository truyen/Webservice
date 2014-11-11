using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTonKho" in both code and config file together.
    [ServiceContract]
    public interface IServiceTonKho
    {
        [OperationContract]
        List<TonKhoe> findAll();

        [OperationContract]
        TonKhoe find(int id);

        [OperationContract]
        bool insert(int soluong, DateTime ngay, int sanpham_chitiet_id);

        [OperationContract]
        bool delete(int id);

        [OperationContract]
        bool update(int id, int soluong, DateTime ngay, int sanpham_chitiet_id);
    }
}
