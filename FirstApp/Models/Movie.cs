using FirstApp.Data.Enums;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Movie
    {
        [Key]

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string MovieDescription { get; set;}     

        public double MoviePrice { get; set; }

        public string MoviePictureUrl { get; set; } 

        public DateTime MovieStartDate { get; set; }

        public DateTime MovieEndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
    }
}
