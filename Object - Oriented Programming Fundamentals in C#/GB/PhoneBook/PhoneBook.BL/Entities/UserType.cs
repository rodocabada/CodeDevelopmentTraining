using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Catalogs
{
    public class UserType : BaseData
    {
        public UserType() : this(id: 0)
        {

        }

        public UserType(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
