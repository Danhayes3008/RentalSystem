using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalSystem.Models
{
    public class Book
    {
        // this is the Id for the items in the table
        [Required]
        public int Id { get; set; }
        [Required]
        public string ISBN { get; set; }

        // title name of the item in the table
        [Required]
        public string Title { get; set; }

        // Who wrote the book
        [Required]
        public string Author { get; set; }

        // information on the book/author
        [Required]
        public string Description { get; set; }

        // allows us to add images to the database
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        // sets the range of the amount of copies available to max of 1,000 and min of 0
        [Required]
        [Range(0, 1000)]
        public int Avaibility { get; set; }

        // sets teh cost of the book
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        // this part of the table will display the date the item was added
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime? DateAdded { get; set; }

        // gets the genre id
        [Required]
        public int GenreId { get; set; }

        // allows you to select a genre for the book being added
        public Genre Genre { get; set; }

        // allows you to enter a date for when the book was published
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime? PublicationDate { get; set; }

        // this is the part that allows you to enter how many pages are in the book
        [Required]
        public int Pages { get; set; }

        [Required]
        public string ProductDemensions { get; set; }

        [Required]
        public string Publisher { get; set; }
    }
}