namespace SocialNetwork.Models.ApplicationEntities.Details
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public Guid Id { get; set; }

        [Required]
        public string CityName { get; set; }

        public virtual ICollection<Street> Streets { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}