namespace SocialNetwork.Models.ApplicationEntities.Details
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Continent
    {
        public int Id { get; set; }

        [Required]
        public string ContinentName { get; set; }

        public virtual ICollection<Country> Countries { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}