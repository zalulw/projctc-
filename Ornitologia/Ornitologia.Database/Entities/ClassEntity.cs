using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornitologia.Database.Entities;
[Table("BirdClass")]
public class ClassEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string ClassName { get; set; }
    [ForeignKey("Subclass")]
    public int SubclassId { get; set; }

    public virtual SubclassEntity Subclass { get; set; }

    public virtual SpeciesEntity Species { get; set; }
}
