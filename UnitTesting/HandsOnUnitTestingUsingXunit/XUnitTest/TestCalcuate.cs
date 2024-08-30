using System;
using Xunit;
using CalculateService;
using System.Collections.Generic;

namespace XUnitTest
{
    public class TestCalcuate
    {
      // Test cases
        
        [Fact]
        public void TestAdd()
        {
           
            //Arrange
            Calculate obj = new Calculate();
            int expected = 3;
            //Act
<<<<<<< HEAD
            int actual = obj.Add(1, 3);
=======
            int actual = obj.Add(1, 4);
>>>>>>> 5c87aca3f28d35fb960f00f9a8c3930cecd64a6d
            
            //Assessrt
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestDiv()
        {
            Calculate obj = new Calculate();
            int actual = obj.Div(10,2);
            Assert.Equal(12,actual);
            
        }
        [Fact]
        public void TestGetNo()
        {
            //Act
            Calculate obj = new Calculate();
            List<int> list = obj.GetNos();
            Assert.NotNull(list);
            Assert.Equal(5, list.Count);
           
        }
<<<<<<< HEAD

        [Fact]

        public void TestSquare()
        {
            double expected = 81;
            double actual=Math.Sqrt(9);

            Assert.Equal(expected, actual);



=======
        [Fact]
        public void TestSquare()
        {
            //Arrange
            double expected = 81;
            //Act
            double actual = Maths.Square(9);
            Assert.Equal(expected, actual);
>>>>>>> 5c87aca3f28d35fb960f00f9a8c3930cecd64a6d
        }
    }
}
