using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSanPham" in both code and config file together.
    [ServiceContract]
    public interface IServiceSanPham
    {
        [OperationContract]
        List<SanPham> findAll();

        [OperationContract]
        SanPham find(int id);

        [OperationContract]
        bool insert(string masp, string ten, string mota, int gia, bool active, int hang_sx);

        [OperationContract]
        bool delete(int id);

        [OperationContract]
        bool update(int id, string masp, string ten, string mota, int gia, bool active, int hang_sx);
    }
}
