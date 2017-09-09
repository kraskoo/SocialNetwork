namespace SocialNetwork.Models.ApplicationEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class UserPost
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn => DateTime.Now;

        public string PostText { get; set; }

        [Required]
        public virtual Wall Wall { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}