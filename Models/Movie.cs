using System;
using System.ComponentModel.DataAnnotations;

namespace myWebApp.Models
{
	public class Movie
	{
        public int ID { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }
    }
}
