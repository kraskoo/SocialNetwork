namespace SocialNetwork.Models.ApplicationEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class MachinePost
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn => DateTime.Now;

        [Required]
        public string Title { get; set; }

        [Required]
        public string DescriptionText { get; set; }
        
        public virtual Image Image { get; set; }

        public virtual Frame Frame { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        [Required]
        public virtual Wall Wall { get; set; }
    }
}