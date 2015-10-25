using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjectWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Produto> FindAll();
        [OperationContract]
        Produto Find(int id);
        [OperationContract]
        Produto New (Produto pro);
        [OperationContract]
        Produto Update(Produto pro);
        [OperationContract]
        Produto DeleteId(int id);
        [OperationContract]
        Produto Delete(Produto pro);
    }
}
