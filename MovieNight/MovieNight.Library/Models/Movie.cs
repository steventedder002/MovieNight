using System;
using System.Collections.Generic;
using MovieNight.Library.Abstracts;
using MovieNight.Library.Models;
using System.Text;
using MovieNight.Library.Enums;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        private string _title
        public List<Actor> Actors
        {
            get;
            set;
        }

        public EGenre Genre
        {
            get;
            set;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                _title = value;
            }
        }

        public Movie()
        {
            Initialize();
        }

        public Movie(string title)                      //Line 30, 34, and 39 create default perameters
        {
            Initialize(title);
        }
        public Movie(string title, EGenre genre)
        {
            Initialize(genre: genre, title:title);
        }

        public Movie(string title, EGenre genre, List<Actor> actors)
        {
            Initialize(title, genre, actors);
        }
        
        public void Initialize(string title="(no title)", EGenre genre = EGenre.Action, List<Actor> actors = null)             
        {
            Title = title;
            Genre = genre;
            Actors = actors ?? new List<Actor> { new Actor() };         //?? is the null operator, it says if left side is null, then use the right
        }
    }
}
