using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Catalogs
{
    public class Shift : BaseData
    {
        public Shift() : this(id: 0)
        {

        }

        public Shift(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
