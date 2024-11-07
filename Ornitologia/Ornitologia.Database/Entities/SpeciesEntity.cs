using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ornitologia.Database.Entities;
[Table("Species")]
public class SpeciesEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string SpeciesName { get; set; }
    [ForeignKey("Class")]
    public int ClassId { get; set; }

    public virtual ClassEntity Class { get; set; }
    public virtual IReadOnlyCollection<BirdEntity> Birds { get; set; }

}
