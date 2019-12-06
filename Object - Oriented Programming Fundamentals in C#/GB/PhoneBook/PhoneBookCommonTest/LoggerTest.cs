using PhoneBook.BL.Catalogs;
using PhoneBook.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PhoneBookCommonTest
{
    public class LoggerTest
    {
        [Fact]
        public void WriteLogTest()
        {
            //Arrange
            var list = new List<ILogger>
            {
                new Employee(1)
                {
                    EmployeeNumber = 1480205,
                    FirstName = "Guillermo",
                    LastName = "Blanco",
                    SecondLastName = "Lozoya"
                },
                new Employee(2)
                {
                    EmployeeNumber = 1480205,
                    FirstName = "Guillermo2",
                    LastName = "Blanco2",
                    SecondLastName = "Lozoya2"
                },
                new Department()
                {
                    Description = "IT"
                }
            };

            //Act
            Logger.WriteLog(list);
    
            //Assert
            //Nothing to assert
        }
    }
}
