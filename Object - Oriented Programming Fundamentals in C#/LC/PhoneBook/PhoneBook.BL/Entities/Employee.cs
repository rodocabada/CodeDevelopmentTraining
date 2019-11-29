namespace PhoneBook.BL.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public string CellphoneNumber { get; set; }
        public string ShortNumber { get; set; }
        public string ExtensionNumber { get; set; }
        public bool Status { get; set; }
        public int IdShift { get; set; }
        public int IdJob { get; set; }
        public int IdDepartment { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName} {SecondLastName}";
            }
        }
    }
}