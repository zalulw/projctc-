using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class EventEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Category { get; set; }
        [Required]
        [StringLength(16)]
        public string SubCategory { get; set; }
        [Required]
        [StringLength(16)]
        public string Gender { get; set; }
        [Required]
        [StringLength(16)]
        public string AgeGroup { get; set; }
    }
}
