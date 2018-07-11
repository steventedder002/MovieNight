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
        public void Test_VotingPeople()                             //testing to see if someone made a vote
        {
            var expected = 0;
            var sut = new Voting();
            var actual = sut.People;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }

        [Fact]
        public void Test_VotingMovie()                                   //testing to see at least one movie will be seen
        {
            var sut = new Voting();

            Assert.NotNull(sut.Movie);
        }
    }
}
