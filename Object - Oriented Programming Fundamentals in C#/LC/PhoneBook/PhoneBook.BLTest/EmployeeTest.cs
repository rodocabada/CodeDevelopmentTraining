using PhoneBook.BL.Entities;
using Xunit;

namespace PhoneBook.BLTest

{
    public class EmployeeTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            var employee = new Employee
            {
                FirstName = "Luis Rodolfo",
                LastName = "Cabada",
                SecondLastName = "Gamillo"
            };
            string expected = "Luis Rodolfo Cabada Gamillo";
            //-- Act
            string actual = employee.FullName;
            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameTestInvalid()
        {
            //-- Arrange
            var employee = new Employee
            {
                FirstName = "Luis Rodolfo",
                LastName = "Cabada",
                SecondLastName = "Gamillo"
            };
            string expected = "Jose Reyes";
            //-- Act
            string actual = employee.FullName;
            //-- Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void EmailTestValid()
        {
            //-- Arrange
            var employee = new Employee
            {
                Email = "luis_cabada@jabil.com"
            };
            string expected = "luis_cabada@jabil.com";
            //-- Act
            string actual = employee.Email;
            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmailTestInvalid()
        {
            //-- Arrange
            var employee = new Employee
            {
                Email = "rodo.cabada@jabil.com"
            };
            string expected = "luis_cabada@jabil.com";
            //-- Act
            string actual = employee.Email;
            //-- Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void ShortNumberTestValid()
        {
            //-- Arrange
            var employee = new Employee
            {
                ShortNumber = "0345"
            };
            string expected = "0345";
            //-- Act
            string actual = employee.ShortNumber;
            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}