using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Catalogs
{
    public class EmployeeRepository
    {
        public Employee Retrieve(int employeeid)
        {
            Employee employee = new Employee(employeeid);

            if (employeeid == 1)
            {
                employee.EmployeeNumber = 1480205;
                employee.FirstName = "Guillermo";
                employee.LastName = "Blanco";
                employee.SecondLastName = "Lozoya";
            }

            return employee;
        }

        public IEnumerable<Employee> Retrieve()
        {
            return new List<Employee>();
        }

        public bool Save(Employee employee)
        {
            return true;
        }
    }
}
