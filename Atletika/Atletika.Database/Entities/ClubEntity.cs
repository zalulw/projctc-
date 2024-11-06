using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class ClubEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
        [Required]
        [StringLength(16)]
        public string Email { get; set; }
        [Required]
        [StringLength(16)]
        public string PhoneNumber { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual CityEntity City { get; set; }

        public virtual IReadOnlyCollection<AthleteEntity> Athletes { get; set; }
    }
}
