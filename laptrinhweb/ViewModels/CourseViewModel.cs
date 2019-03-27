﻿using laptrinhweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laptrinhweb.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}