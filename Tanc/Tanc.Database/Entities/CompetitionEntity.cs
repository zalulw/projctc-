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
    public string Date { get; set; }

    [ForeignKey("Group")]
    public uint GroupId { get; set; }
    public virtual GroupEntity Group { get; set; } //navigation property

    [ForeignKey("Location")]
    public uint LocationId { get; set; }
    public virtual LocationEntity Location { get; set; } //navigation property
}
