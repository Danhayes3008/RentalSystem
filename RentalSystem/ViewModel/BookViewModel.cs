using RentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalSystem.ViewModel
{
    public class BookViewModel
    {
        public IEnumerable<Genre> Genes { get; set; }
        public Book Book { get; set; }
        public List<Genre> Genres { get; internal set; }
    }
}