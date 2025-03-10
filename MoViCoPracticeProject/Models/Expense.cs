
using System.ComponentModel.DataAnnotations;

namespace MoViCoPracticeProject.Models
{
    public class Espense
    {
        public int Id { get; set; }
        public decimal Vaule { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}