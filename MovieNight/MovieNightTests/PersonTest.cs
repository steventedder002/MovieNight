using System;
using System.Collections.Generic;
using MovieNight.Library.Models;
using System.Text;
using Xunit;

namespace MovieNightTests
{
    public class PersonTest
    {
        [Fact]
        public void Test_PersonId()
        {
            var expected = typeof(Guid);                //setting what we expect the test to actually product
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
