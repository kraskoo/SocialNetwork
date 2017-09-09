namespace SocialNetwork.Models.ApplicationEntities
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}