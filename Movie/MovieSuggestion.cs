﻿namespace Movie
{
    public class MovieSuggestion : IMovieSuggestion
    {
        private readonly IMovieScore movieScore;

        public MovieSuggestion(IMovieScore movieScore)
        {
            this.movieScore = movieScore;
        }

        public bool IsGoodMovie(string title)
        {
            var score = this.movieScore.Score(title);
            return score >= 8;
        }
    }
}