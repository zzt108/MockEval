using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public interface IMovieSuggestion
    {
        bool IsGoodMovie(string title);
    }
    public interface IMovieScore
    {
        double Score(string title);
    }
}
