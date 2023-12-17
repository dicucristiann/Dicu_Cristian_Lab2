﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Dicu_Cristian_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Book>? Books { get; set; }

        [Display(Name = "Author")]
        public string FullName => $"{FirstName} {LastName}";
    }
}