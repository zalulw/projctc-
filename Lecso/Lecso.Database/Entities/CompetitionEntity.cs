using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecso.Database.Entities
{
    public class CompetitionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Date { get; set; }

        [ForeignKey("Location")]
        public uint LocationId { get; set; }

        [ForeignKey("Team")]
        public uint TeamId { get; set; }

        [ForeignKey("Judge")]
        public uint JudgeId { get; set; }


        public virtual LocationEntity Location { get; set; }
        public virtual TeamEntity Team { get; set; }
        public virtual JudgeEntity Judge { get; set; }
    }
}
