using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Catalogs
{
    public class Job : BaseData
    {
        public Job() : this(id: 0)
        {

        }

        public Job(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int IdDepartment { get; set; }
    }
}
