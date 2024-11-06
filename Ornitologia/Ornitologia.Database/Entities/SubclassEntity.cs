using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornitologia.Database.Entities;
[Table("Subclass")]
public class SubclassEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string SubclassName { get; set; }
    [ForeignKey("Tribe")]
    public int TribeId { get; set; }
    
    public virtual TribeEntity Tribe { get; set; }
    public virtual ClassEntity Class { get; set; }
}
