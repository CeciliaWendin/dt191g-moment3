using System.ComponentModel.DataAnnotations;
using Collection.Enums;

namespace Collection.Data.Entities
{
   public class Album
   {
        public int Id { get; set; }
         [Required]
        [Display(Name = "Titel")]
        public string? Title { get; set; }
         [Required]
        [Display(Name = "Artist")]
        public int? ArtistId {get; set;}
        public Artist? Artist { get; set; }
        [Display(Name = "Publicerad")]
        public int? PubYear { get; set; }
        [Display(Name = "Genre")]
        public GenreList? GenreList { get; set; }
   }
}