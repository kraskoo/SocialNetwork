namespace SocialNetwork.Models.ApplicationEntities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        public Guid Id { get; set; }

        [Required]
        public string ActualAddress { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}