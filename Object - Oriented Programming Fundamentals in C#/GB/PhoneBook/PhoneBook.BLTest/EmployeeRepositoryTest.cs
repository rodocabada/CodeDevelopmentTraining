using PhoneBook.BL.Catalogs;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PhoneBook.BLTest
{
    public class EmployeeRepositoryTest
    {
        [Fact]
        public void RetieveValid()
        {
            var employeeRepository = new EmployeeRepository();

            var expected = new Employee(1)
            {
                EmployeeNumber = 1480205,
                FirstName = "Guillermo",
                LastName = "Blanco",
                SecondLastName = "Lolzoya"
            };
            //-- Act
            var actual = employeeRepository.Retrieve(1);

            //--Assert
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.EmployeeNumber, actual.EmployeeNumber);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.SecondLastName, actual.SecondLastName);
        }
    }
}
