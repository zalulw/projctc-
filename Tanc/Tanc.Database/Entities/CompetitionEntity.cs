using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tanc.Database.Entities;
[Table("Competition")]
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

    [ForeignKey("Street")]
    public uint StreetId { get; set; }
    public virtual StreetEntity Street { get; set; } //navigation property
    public virtual IReadOnlyCollection<TeamEntity> Teams { get; set; }
}
