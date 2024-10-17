using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecso.Database.Entities
{
    public class LocationEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint PostalCode { get; set; }

        [Required]
        [StringLength(15)]
        public string CityName { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public uint HouseNumber { get; set; }
        public virtual IReadOnlyCollection<CompetitionEntity> Competitions { get; set; } //navigation property

    }
}
