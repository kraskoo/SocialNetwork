namespace SocialNetwork.Models.ApplicationEntities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class UserInformation
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<InformationDetail> InformationDetails { get; set; }
    }
}