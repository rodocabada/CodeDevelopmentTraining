using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Catalogs
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string ShortNumber { get; set; }
        public string ExtensionNumber { get; set; }
        public bool Status{ get; set; }
        public int IdShift { get; set; }
        public int IdJob { get; set; }
        public int IdDepartment { get; set; }
    }
}
