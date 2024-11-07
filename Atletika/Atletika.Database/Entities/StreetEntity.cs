using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class StreetEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
        [Required]
        public int HouseNumber { get; set; }

        [ForeignKey("City")]
        public int PostalCode { get; set; }
        public virtual CityEntity City { get; set; }
    }
}
