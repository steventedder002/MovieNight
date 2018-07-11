using System;
using System.Collections.Generic;
using System.Text;
using MovieNight.Library.Models;
using Xunit;

namespace MovieNightTests
{
    public class MovieTest
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);                //setting what we expect the test to actually product
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MoviesMovieList()             //checking to see if at least one person will play in the movie
        {
            var expected = 1;
            var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
