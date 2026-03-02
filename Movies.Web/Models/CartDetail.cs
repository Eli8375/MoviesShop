using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Web.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        public int MovieId { get; set; }
        public int Quantity { get; set; }
        public Movie Movie { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
