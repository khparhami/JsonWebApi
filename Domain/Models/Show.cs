﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Models
{
    public class Show
    {
        public string image { get; set; }
        public string slug { get; set; }
        public string title { get; set; }

        public override bool Equals(object obj)
        {
            return this.image == ((Show)obj).image && this.slug == ((Show)obj).slug && this.title == ((Show)obj).title;
        }
    }
}