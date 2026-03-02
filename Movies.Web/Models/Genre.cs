using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Web.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
