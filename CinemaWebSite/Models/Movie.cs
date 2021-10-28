using CinemaWebSite.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }

        public MovieCategory movieCategory { get; set; }

        //Releationship
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaID { get; set; }
        //forigen Key
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerID { get; set; }
        //forigen Key
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }
    }
}
