﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServersideServices.DAL.Models
{
   public class MovieProperties
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        //public string belongs_to_collection { get; set; }
        public List<spoken_languages> spoken_languages { get; set; }
        public double budget { get; set; }
        public List<genres> genres { get; set; }
        public int id { get; set; }
        // public string imdb_id { get; set; }
        public string original_title { get; set; }
        public string original_language { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public string tagline { get; set; }
        public List<production_companies> production_companies { get; set; }
        public List<production_countries> production_countries { get; set; }
        public string release_date { get; set; }
        public double revenue { get; set; }
        public string homepage { get; set; }
        public int runtime { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }
}
