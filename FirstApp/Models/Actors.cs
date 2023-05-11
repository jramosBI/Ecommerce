using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Actors
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorProfilePictureUrl { get; set; }

        public string ActorFullName { get; set; }

        public string ActorBiograph { get; set; }

    }
}
