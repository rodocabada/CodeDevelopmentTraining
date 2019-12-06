using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.BL.Interfaces
{
    public interface IBaseData
    {
        int? UserLastUpdated { get; set; }
        DateTime? LastUpdated { get; set; }
    }
}
