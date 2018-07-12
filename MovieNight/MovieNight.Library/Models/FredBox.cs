using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class FredBox
    {
        private List<Movie> Movies;

        public FredBox()
        {
            Movies = new List<Movie>();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return Movies;
        }

        public Movie MakeMovie(string title)
        {
            Movie movie = new Movie();
            try
            {
                if(string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentNullException(title, "Title cannot be null or whitespaced...");
                }
                else
                {
                    movie = new Movie()
                    {
                        Title = title
                    };
                }
            }
            catch (ArgumentNullException ex)            //very specific exception
            {
                MakeMovie("Not Available");
            }
            catch (ArgumentException ex)                //very specific exception
            {
                throw new Exception("Not sure how it happened", ex);
            }
            catch (Exception ex)                        //very vague exception
            {
                throw;
            }
            finally
            {
                GC.Collect();
            }
            return movie;
        }

        public void DistributeMovies(Movie movie)
        {
            Movies.Add(movie);
        }
    }
}
