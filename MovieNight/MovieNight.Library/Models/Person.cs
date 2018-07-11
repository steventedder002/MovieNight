﻿using System;
using System.Collections.Generic;
using MovieNight.Library.Abstracts;
using MovieNight.Library.Models;
using System.Text;

namespace MovieNight.Library.Models 
{
    public class Person : AModel
    {
        public History History
        {
            get;
            set;
        }
        public Person()
        {
            History = new History();
        }
    }
}
