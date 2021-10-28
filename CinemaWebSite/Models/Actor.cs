﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        public string profilePictureURL { get; set; }

        //Releationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}