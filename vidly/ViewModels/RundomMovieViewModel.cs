﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;
using Vidly.Models;

namespace vidly.ViewModels
{
    public class RundomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}