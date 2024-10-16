using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanc.Database.Entities
{
    public class TeamEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string TeamName { get; set; }
        
        public string Nationality { get; set; }

        public string Choreographer { get; set; }

        public int Points { get; set; }

        public virtual IReadOnlyCollection<MemberEntity> Members { get; set; }
    }
}
