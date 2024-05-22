using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ErrorModel
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(Guid employeeId) : base($"Emmployee with id: {employeeId} doesn't exist in the database.") 
        {
            
        }
    }
}
