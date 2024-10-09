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
    [StringLength(8)]
    public string Gender { get; set; }

    [Required]
    [StringLength(16)]
    public string BirthDate { get; set; }

    [ForeignKey("Group")]
    public uint GroupId { get; set; }
    public virtual GroupEntity Group { get; set; } //navigation property

    [ForeignKey("Location")]
    public uint LocationId { get; set; }
    public virtual LocationEntity Location { get; set; } //navigation property
}
