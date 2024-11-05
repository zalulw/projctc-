using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class StreetEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
        [Required]
        public uint HouseNumber { get; set; }

        [ForeignKey("City")]
        public uint CityId { get; set; }
        public virtual CityEntity City { get; set; }
    }
}
