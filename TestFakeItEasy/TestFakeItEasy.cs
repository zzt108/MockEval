using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Movie;
using FakeItEasy;
using FluentAssertions;

namespace TestFakeItEasy
{
    [TestClass]
    public class TestFakeItEasy
    {
        [DataRow(false, 0)]
        [DataRow(false, 0)]
        [DataRow(false, 7.99)]
        [DataRow(true, 8)]
        [DataRow(true, 10)]
        public void CanSuggest(bool expected, double score)
        {
            // Arrange
            var movieScore = A.Fake<IMovieScore>();
            A.CallTo(() => movieScore.Score(A<string>.Ignored)).Returns(score);
            var movieSuggestion = new MovieSuggestion(movieScore);
            var title = Guid.NewGuid().ToString();

            // Act
            var isGood = movieSuggestion.IsGoodMovie(title);

            // Assert
            isGood.Should().Be(expected);
            A.CallTo(() => movieScore.Score(title)).MustHaveHappened();

        }
    }
}
