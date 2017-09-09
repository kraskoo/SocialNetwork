namespace SocialNetwork.Models.ApplicationEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Frame
    {
        public Guid Id { get; set; }

        [Required]
        public string FrameUrl { get; set; }
    }
}