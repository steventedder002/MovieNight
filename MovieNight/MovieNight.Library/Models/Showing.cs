﻿using System;
using System.Collections.Generic;
using MovieNight.Library.Abstracts;
using MovieNight.Library.Models;
using System.Text;

namespace MovieNight.Library.Models 
{
    public class Showing : AModel
    {
        public List<Movie> Movies
        {
            get;
            set;
        }

        public Showing()
        {
            Movies = new List<Movie>()
            {
                new Movie()
            };

        }
    }
}
