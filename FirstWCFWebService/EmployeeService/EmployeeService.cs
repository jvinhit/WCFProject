using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        void AddEmployee(Employee emp);
        [OperationContract]
        List<Employee> GetEmployeeByName(string name);
        [OperationContract]
        void DeleteEmployeeById(string EmpID);
    }
}
