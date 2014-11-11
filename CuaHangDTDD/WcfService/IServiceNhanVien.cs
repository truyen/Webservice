using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceNhanVien" in both code and config file together.
    [ServiceContract]
    public interface IServiceNhanVien
    {
        [OperationContract]
        List<NhanVien> findAll();

        [OperationContract]
        NhanVien find(int id);

        [OperationContract]
        bool insert(string ten, string pass, int quyen);

        [OperationContract]
        bool delete(int id);

        [OperationContract]
        bool update(int id, string ten, string pass, int quyen);
    }
}
