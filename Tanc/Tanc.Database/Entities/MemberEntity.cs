using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tanc.Database.Entities;
[Table("Member")]
public class MemberEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(16)]
    public string Name { get; set; }

    [Required]
    [StringLength(16)]
    public string Sex { get; set; }

    [Required]
    [StringLength(16)]
    public string DateOfBirth { get; set; }

    [ForeignKey("Street")]
    public uint StreetId { get; set; }
    public virtual StreetEntity Street { get; set; } //navigation property
}
