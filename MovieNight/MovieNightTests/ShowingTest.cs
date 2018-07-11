using System;
using System.Collections.Generic;
using System.Text;
using MovieNight.Library.Models;
using Xunit;

namespace MovieNightTests
{
    public class ShowingTest
    {
        [Fact]
        public void Test_ShowingId()
        {
            var expected = typeof(Guid);                //setting what we expect the test to actually product
            var sut = new Showing();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_ShowingMovieList()             //testing to see if at least one movie is showing
        {
            var expected = 1;
            var sut = new Showing();
            var actual = sut.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
