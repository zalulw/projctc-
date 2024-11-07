using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornitologia.Database.Entities;
[Table("Note")]
public class NoteEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("Bird")]
    public int BirdId { get; set; }
    [ForeignKey("Member")]
    public int MemberId { get; set; }
    [Required]
    public StreetEntity Location { get; set; }
    [Required]
    public string Date { get; set; }

    public virtual BirdEntity Bird { get; set; }
    public virtual MemberEntity Member { get; set; }

}
