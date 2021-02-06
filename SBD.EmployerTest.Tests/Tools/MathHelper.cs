using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SBD.EmployerTest.Tests.Tools
{
    public class MathHelper
    {
        [Theory]
        [InlineData(8, false)]
        [InlineData(9999999, false)]
        [InlineData(1, true)]
        [InlineData(27, true)]
        public void IsPowerOfThree(int value, bool expected)
        {
            var result = SBD.EmployerTest.Tools.MathHelper.IsPowerOfThree(value);
            Assert.Equal(expected, result);
        }
    }
}
