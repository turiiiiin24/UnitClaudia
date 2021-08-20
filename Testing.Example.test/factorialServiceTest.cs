using System;
using System.Collections.Generic;
using System.Text;
using Testing_Example;
using Xunit;
namespace Testing.Example.test
{
   public class factorialServiceTest
    {

       [Fact]
        public void TesttFactorialZero()

        {

            FactorialService service   = new FactorialService();

            int result = service.Calculate(0);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TesttFactorialFive()

        {

            FactorialService service = new FactorialService();

            int result = service.Calculate(5);

            Assert.Equal(120, result);
        }




    }
}
