using System;
using System.Collections.Generic;
using System.Text;
using PhoneBook.BL.Catalogs;
using Xunit;

namespace PhoneBook.BLTest
{
    public class EmployeeTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            var employee = new Employee
            {
                FirstName = "Guillermo",
                LastName = "Blanco",
                SecondLastName = "Lozoya"
            };
            string expected = "Guillermo Blanco Lozoya";
            string actual = employee.FullName;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FullNameTestInvalid()
        {
            var employee = new Employee
            {
                FirstName = "Guillermo",
                LastName = "Blanco",
                SecondLastName = "Lozoya"
            };
            string expected = "Guillermo Blanco";
            string actual = employee.FullName;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void EmailTestValid()
        {
            var employee = new Employee
            {
                Email = "guillermo_blanco@jabil.com"
            };
            string expected = "guillermo_blanco@jabil.com";
            string actual = employee.Email;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmailTestInvalid()
        {
            var employee = new Employee
            {
                Email = "guillermo_blanco@jabil.com"
            };
            string expected = "guillermoblanco@jabil.com";
            string actual = employee.Email;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void EmployeeShortNumberValid()
        {
            var employee = new Employee
            {
                ShortNumber = "1234"
            };
            string expected = "1234";
            string actual = employee.ShortNumber;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmployeeShortNumberInvalid()
        {
            var employee = new Employee
            {
                ShortNumber = "1234"
            };
            string expected = "1243";
            string actual = employee.ShortNumber;
            Assert.NotEqual(expected, actual);
        }
    }
}
