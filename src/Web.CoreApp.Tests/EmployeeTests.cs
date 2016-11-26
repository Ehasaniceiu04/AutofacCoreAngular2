using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Web.CoreApp.Tests
{
 
    public class EmployeeTests
    {
        IEmployee sut;
        public  EmployeeTests()
        {
            sut = new Employee();
        }
       [Fact]
        public void IsMale_should_return_false_value_if_input_is_not_one()
        {
            Assert.False(sut.IsMale(2));
        }

        [Fact]
        public void IsMale_should_return_true_if_input_is_one()
        {
            Assert.True(sut.IsMale(1));
        }


    }
}
