﻿namespace PhoneBook.BL.Entities
{
    public class User : BaseData
    {
        public User() : this(0)
        {
        }

        public User(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public int IdUserType { get; set; }
        public int IdShift { get; set; }
        public int IdDepartment { get; set; }
    }
}