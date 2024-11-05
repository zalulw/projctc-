using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class CompetitionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
        [Required]
        [StringLength(16)]
        public string StartDate { get; set; }
        [Required]
        [StringLength(16)]
        public string EndDate { get; set; }
        [Required]
        public uint Year { get; set; }

        [ForeignKey("Street")]
        public uint StreetId { get; set; }
        public virtual StreetEntity Street { get; set; }

        public virtual IReadOnlyCollection<EnrollmentEntity> Enrollments { get; set; }
    }
}
