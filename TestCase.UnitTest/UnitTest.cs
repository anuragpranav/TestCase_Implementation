using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCase.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        Program program;
        public UnitTest()
        {
            program = new Program();
        }

        [TestMethod]
        public void Test_Add()
        {
            //Arrange
            int a = 5, b = 6;
            
            //Act
            int CalValue = program.Add(a,b);

            //Assert
            Assert.AreEqual(a + b, CalValue);
        }

        [TestMethod]
        public void Test_Sub()
        {
            //Arrange
            int a = 5, b = 6;

            //Act
            int CalValue = program.Sub(a, b);

            //Assert
            Assert.AreEqual(a - b, CalValue);
        }

        [TestMethod]
        public void Test_Mul()
        {
            //Arrange
            int a = 5, b = 6;

            //Act
            int CalValue = program.Mul(a, b);

            //Assert
            Assert.AreEqual(a * b, CalValue);
        }

        [TestMethod]
        public void Test_Div()
        {
            //Arrange
            int a = 5, b = 6;

            //Act
            int CalValue = program.Div(a, b);

            //Assert
            Assert.AreEqual(a / b, CalValue);
        }
    }
}
