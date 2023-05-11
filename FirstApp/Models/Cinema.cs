using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Cinema
    {

        [Key]

        public int CinemaId { get; set; }

        public string CinemaLogo { get; set; }

        public string CinemaName { get; set; }

        public string CinemaDescription { get; set; }

    
    }
}
