using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class EnrollmentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        public uint Placement { get; set; }
        public uint Score { get; set; }
        [Required]
        public bool Participated { get; set; }

        [ForeignKey("Competition")]
        public uint CompetitionId { get; set; }
        public virtual CompetitionEntity Competition { get; set; }

        [ForeignKey("Athlete")]
        public uint AthleteId { get; set; }
        public virtual AthleteEntity Athlete { get; set; }

        [ForeignKey("Event")]
        public uint EventId { get; set; }
        public virtual EventEntity Event { get; set; }
    }
}
