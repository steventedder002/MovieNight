using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class FredBoxTests
    {
        private FredBox sut;

        public FredBoxTests()
        {
            sut = new FredBox();
        }

        [Fact]
        public void Test_MakeMovie()
        {
            var expected = "My First Movie";
            var actual = sut.MakeMovie(expected);

            Assert.True(expected == actual.Title);
        }

        [Fact]
        public void Test_StoreMovie()
        {
            var expected = 0;
            var actual = sut.GetMovies();

            Assert.True(expected <= actual.Count());
        }

        [Fact]
        public void Test_FredBoxMakeMovie_Nagative()
        {
            string title = null;
            var actual = sut.MakeMovie(title);

            Assert.NotNull(actual.Title);
        }

        [Fact]
        public void Test_DistributeMovie()
        {
            var title = "My Second Movie";
            var expected = sut.GetMovies();

            sut.DistributeMovies(sut.MakeMovie(title));
            var actual = sut.GetMovies();

            Assert.True(expected < actual.Count);
        }
    }
}
