﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Director
    {
        public Director()
        {
            this.Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> BirthDate { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}