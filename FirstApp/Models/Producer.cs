using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Producer
    {

        [Key]

        public int ProducerId { get; set; }

        public string ProducerProfilePictureUrl { get; set; }

        public string ProducerFullName { get; set; }

        public string ProducerBiograph { get; set;}

    }
}
