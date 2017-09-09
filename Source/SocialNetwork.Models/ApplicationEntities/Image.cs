namespace SocialNetwork.Models.ApplicationEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public Guid Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}