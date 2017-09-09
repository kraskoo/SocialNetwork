namespace SocialNetwork.Models.ApplicationEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public virtual User Author { get; set; }

        [Required]
        public DateTime PostedOn => DateTime.Now;

        public virtual UserPost UserPost { get; set; }

        public virtual MachinePost MachinePost { get; set; }
    }
}