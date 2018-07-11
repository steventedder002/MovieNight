﻿using System;
using System.Collections.Generic;
using MovieNight.Library.Abstracts;
using MovieNight.Library.Models;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Actor> Actors
        {
            get;
            set;
        }

        public Movie()
        {
            Actors = new List<Actor>()
            {
                new Actor()
            };
        }
    }
}
