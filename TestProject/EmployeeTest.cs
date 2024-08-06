using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class EmployeeTest
    {
        [Test]
        public void GetLeavesTest1()
        {
           NumericFunctions.Employee employee = new NumericFunctions.Employee();
            string actual = employee.GetLeaves(10, "HR");
            Assert.AreEqual("You can get 10 leaves", actual);
        }


        [TestCase(9, "HR", "You can get 5 leaves")]
        [TestCase(8, "Sales", "You can get 15 leaves")]
        [TestCase(8, "Acts", "No Leaves")]

        public void GetLeavesTest(int exp, string dept, string expected)
        {
            NumericFunctions.Employee employee = new NumericFunctions.Employee();
            string actual = employee.GetLeaves(exp, dept);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddUserTest()
        {
            Mock<NumericFunctions.EMail> obj = new Mock<NumericFunctions.EMail>();
            // Setup the moq
            obj.Setup(x => x.SendMail()).Returns(true);
            NumericFunctions.Employee employee = new NumericFunctions.Employee();
            bool isInserted = employee.AddUser(obj.Object);
            Assert.AreEqual(isInserted, true);
        }    
    }
}

