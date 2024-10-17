using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tanc.Database.Entities;
[Table("Team")]
public class TeamEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(16)]
    public string TeamName { get; set; }

    [Required]
    [StringLength(16)]
    public string Choreographer { get; set; }

    [Required]
    public uint Points { get; set; }

    [ForeignKey("Country")]
    public uint CountryId { get; set; }
    public virtual CountryEntity Country { get; set; } //navigation property

    public virtual IReadOnlyCollection<MemberEntity> Members { get; set; }
}
