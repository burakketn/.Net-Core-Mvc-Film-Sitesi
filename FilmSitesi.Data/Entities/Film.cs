using System.ComponentModel.DataAnnotations;

namespace FilmSitesi.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public int LikeCount { get; set; }

        public int DislikeCount { get; set; }
    }
}
