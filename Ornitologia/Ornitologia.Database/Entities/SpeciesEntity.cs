using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public virtual BirdEntity Bird { get; set; }

}
