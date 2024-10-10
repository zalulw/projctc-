using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecso.Database.Entities
{
    public class MemberEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("Team")]
        public uint TeamId { get; set; }
        public virtual TeamEntity Team { get; set; } //nav property
    }
}
