using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Web.Models
{
    [Table("Movie")]
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? Title { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Description { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre? Genre;
        public int rating { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; }
        public List<OrderDetail> OrderDtail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
    }
}
