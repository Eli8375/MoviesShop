using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Web.Models
{
    [Table("Actor")]
    public class Actor
    {
        public int Id { get; set; }
    }
}
