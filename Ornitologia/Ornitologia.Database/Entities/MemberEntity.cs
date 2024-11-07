using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornitologia.Database.Entities;
[Table("Member")]
public class MemberEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int MembershipCardNumber { get; set; }
    [Required]
    public string Name { get; set; }

    [ForeignKey("Street")]
    public int StreetId { get; set; }
    [Required]
    public string StartOfMembership { get; set; }
    [Required]
    public string EndOfMembership { get; set; }

    public virtual StreetEntity Street { get; set; }
    public virtual IReadOnlyCollection<BirdEntity> Birds { get; set; }
    public virtual IReadOnlyCollection<NoteEntity> Notes { get; set; }
}
