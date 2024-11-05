using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class CityEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint PostalCode { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }

        public virtual IReadOnlyCollection<StreetEntity> Streets { get; set; }
    }
}
