using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace EmployeeService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class EmployeeServices:IEmployee
    {
        List<Employee> emplist = null;
        public EmployeeServices()
        {
            if(emplist == null)
            {
                emplist = new List<Employee>();
            }
        }

        public void AddEmployee(Employee emp)
        {
            emplist.Add(emp);
        }

        public List<Employee> GetEmployeeByName(string name)
        {
            return emplist.FindAll(a => a.Name.Equals(name));
        }

        public void DeleteEmployeeById(string EmpID)
        {
            emplist.Remove(emplist.Find(a => a.EmpID == EmpID));
        }
    }
}
