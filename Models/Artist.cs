using System.ComponentModel.DataAnnotations;

namespace Collection.Data.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

    }
}