using System;
using System.Collections.Generic;
using MathProCorporation.TaskManagerDatabase;

namespace MathProCorporation.Service
{
    public class EmployeeService : Service<Employee>
    {
        public EmployeeService(CompanyContext context)
            : base(context)
        {
        }

        private List<Task> getTasks(String employeeId)
        {
            return GetByID(employeeId).Tasks;
        }

        private List<Task> getTasks(Employee employee)
        {
            return employee.Tasks;
        }
    }
}