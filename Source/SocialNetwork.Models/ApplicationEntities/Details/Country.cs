namespace SocialNetwork.Models.ApplicationEntities.Details
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string CountryName { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}