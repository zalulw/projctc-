using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tanc.Database.Entities;
[Table("Street")]
public class StreetEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(16)]
    public string StreetName { get; set; }

    [Required]
    public uint DoorNumber { get; set; }

    [ForeignKey("City")]
    public int CityId { get; set; }
    public virtual CityEntity City { get; set; } //navigation property
}
