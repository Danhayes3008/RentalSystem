using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalSystem.Models
{
    // this class is for the Genre table
    public class Genre
    {
        //Gives the Genre a Id number
        [Required]
        public int Id { get; set; }

        // gives the genre a name
        [Required]
        [DisplayName("Genre Name")]
        public string Name { get; set; }

    }
}