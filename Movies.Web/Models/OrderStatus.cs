using System.ComponentModel.DataAnnotations;

namespace Movies.Web.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string? StatusName { get; set; }
    }
}
