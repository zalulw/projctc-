using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class EnrollmentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public uint Placement { get; set; }
        public uint Score { get; set; }
        [Required]
        public bool Participated { get; set; }

        [ForeignKey("Competition")]
        public int CompetitionId { get; set; }
        public virtual CompetitionEntity Competition { get; set; }

        [ForeignKey("Athlete")]
        public int AthleteId { get; set; }
        public virtual AthleteEntity Athlete { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public virtual EventEntity Event { get; set; }
    }
}
