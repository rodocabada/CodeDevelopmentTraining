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
    }
}