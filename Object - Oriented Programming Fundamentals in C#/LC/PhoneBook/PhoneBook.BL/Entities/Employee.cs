using System;
using System.Linq;

namespace PhoneBook.BL.Entities
{
    public class Employee : BaseData
    {
        public Employee() : this(0)
        {
        }

        public Employee(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        private string _email;

        public string Email
        {
            get { return this._email; }
            set { this._email = IsValidEmail(value) ? value : throw new InvalidOperationException("The email is not valid."); }
        }

        public string CellphoneNumber { get; set; }
        private string _shortNumber;

        public string ShortNumber
        {
            get { return _shortNumber; }
            set { this._shortNumber = IsValidShortNumber(value) ? value : throw new InvalidOperationException("The short number is not valid"); }
        }

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

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidShortNumber(string shortNumber)
        {
            try
            {
                var length = shortNumber.Length;
                if (!(length == 4 && IsNumeric(shortNumber)))
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}