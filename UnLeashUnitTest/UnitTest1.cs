using System;
using UnLeashPorject.Controllers;
using Xunit;

namespace UnLeashUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "One")]
        public void SingleDigit_ShouldReturnCorrectString(int num, string expected)
        {

            var result = Helpers.singleDigit(num);

            Assert.Equal(expected, result);
        }
    }
}
