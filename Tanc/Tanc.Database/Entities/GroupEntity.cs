namespace Tanc.Database.Entities;

[Table("Group")]
public class GroupEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(16)]
    public string GroupName { get; set; }

    [Required]
    [StringLength(16)]
    public string ChoreographerName { get; set; }

    [Required]
    public uint Points { get; set; }
}
