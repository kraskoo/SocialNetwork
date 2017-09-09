namespace SocialNetwork.Models.ApplicationEntities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Wall
    {
        public int Id { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<UserPost> UserPosts { get; set; }

        public virtual ICollection<MachinePost> MachinePosts { get; set; }
    }
}