using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Catalogs
{

    public class Employee : BaseData
    {
        public Employee():this(id:0)
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
        //public string Email { get; set; }
        public string Cellphone { get; set; }
        //public string ShortNumber { get; set; }
        public string ExtensionNumber { get; set; }
        public bool Status { get; set; }
        public int IdShift { get; set; }
        public int IdJob { get; set; }
        public int IdDepartment { get; set; }

        private string _email;
        private string _shortNumber;
        private int myVar;

        public string Email
        {
            get { return this._email; }
            set => this._email = IsValidEmail(value) ? value : throw new InvalidOperationException("the email is no valid.");
        }

        public string ShortNumber
        {
            get { return _shortNumber;}
            set { this._shortNumber = IsValidShortNumber(value) ? value : throw new InvalidOperationException("The short number is not valid"); }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName} {SecondLastName}";
            }
        }

        public bool IsValidEmail(string email)
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

        public bool IsValidShortNumber(string shortNumber)
        {
            try
            {
                var lenght = shortNumber.Length;
                if (!(lenght == 4 && IsNumeric(shortNumber)))
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
        public static bool IsNumeric(string s)
        {
            int output;
            return int.TryParse(s, out output);
        }

        
    }
}