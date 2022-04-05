using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IEmployeeRepository
    {
         Task<bool> Create(Employee emp);
         Task<List<Employee>> GetEmployee(int? id);
         Task Edit(Employee emp);
         Task<bool> Delete(int id);

    }
}
