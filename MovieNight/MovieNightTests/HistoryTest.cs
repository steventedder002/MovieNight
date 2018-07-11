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

        [Fact]
        public void Test_HistoryMovieList()             //checking to see if at least one movie has been seen
        {
            var expected = 1;
            var sut = new History();
            var actual = sut.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
