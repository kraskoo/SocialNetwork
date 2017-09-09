namespace SocialNetwork.Models.ApplicationEntities
{
    using System.ComponentModel.DataAnnotations;

    public class InformationDetail
    {
        public int Id { get; set; }

        [Required]
        public string DetailClassification { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}