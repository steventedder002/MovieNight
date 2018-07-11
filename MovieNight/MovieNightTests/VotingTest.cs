using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MovieNight.Library.Models;

namespace MovieNightTests
{
    public class VotingTest
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);                //setting what we expect the test to actually product
            var sut = new Voting();
            var actual = sut.Id;
            
            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_VotingMovie()
        {
            var expected = 1;
            var sut = new Voting();
            var actual = sut.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
