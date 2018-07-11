using System;
using System.Collections.Generic;
using System.Text;
using MovieNight.Library.Models;
using Xunit;

namespace MovieNightTests
{
    public class HistoryTest
    {
        [Fact]
        public void Test_HistoryId()
        {
            var expected = typeof(Guid);                //setting what we expect the test to actually product
            var sut = new History();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
