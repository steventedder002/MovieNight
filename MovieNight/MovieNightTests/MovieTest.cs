using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieNight.Library.Enums;
using MovieNight.Library.Models;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        //Movie movie = new Movie();                  //A way of setting the Movie() a global constant throughout the code. However, this will create a large list of garbage code
        private Movie sut;

        public MovieTests()                     //The correct way of setting the global constant. says that this will only run when you run Movie test
        {
            sut = new Movie();
        }

        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);                //setting what we expect the test to actually product
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MoviesMovieList()             //checking to see if at least one person will play in the movie
        {
            var expected = 1;
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);            
        }

        [Fact]
        public void Test_MovieTitle()
        {
            var expected = typeof(string);

            Assert.True(expected == sut.Title.GetType());       //test to see if it is a string
            Assert.NotEmpty(sut.Title);                         //tests to see that there is a title
        }

        [Fact]
        public void Test_MovieGenre()
        {
            var expected = typeof(EGenre);

            Assert.True(expected == sut.Genre.GetType());
            //Assert.NotEqual(EGenre.None, sut.Genre);
        }
    }
}
