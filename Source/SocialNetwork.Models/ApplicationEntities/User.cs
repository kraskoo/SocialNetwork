namespace SocialNetwork.Models.ApplicationEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public override string UserName => $"{this.FirstName} {this.LastName}";

        [Required]
        public virtual Wall Wall { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public ICollection<UserFriend> UserFriends { get; set; }
    }
}