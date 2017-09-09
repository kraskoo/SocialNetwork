namespace SocialNetwork.Models.ApplicationEntities.Details
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Street
    {
        public Guid Id { get; set; }

        [Required]
        public string StreetName { get; set; }

        public int? StreetNumber { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}