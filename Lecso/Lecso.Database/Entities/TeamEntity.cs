using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecso.Database.Entities
{
    public class TeamEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public uint Points { get ; set; }

        public virtual IReadOnlyCollection<MemberEntity> Members { get; set; }

        public virtual IReadOnlyCollection<CompetitionEntity> Competitions { get; set; }

    }
}
 