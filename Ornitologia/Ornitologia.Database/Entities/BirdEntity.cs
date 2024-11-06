using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ornitologia.Database.Entities;
[Table("Bird")]
public class BirdEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int RingNumber { get; set; }
    [ForeignKey("Species")]
    public int SpeciesId { get; set; }
    [ForeignKey("Member")]
    public MemberEntity WhoRinged { get; set; }
    [ForeignKey("Street")]
    public StreetEntity WhereRinged { get; set; }
    [Required]
    public string DateOfRinging { get; set; }

    public NoteEntity Note { get; set; }

    public virtual SpeciesEntity Species { get; set; }//nav
    public virtual MemberEntity Member { get; set; }
    public virtual StreetEntity StreetEntity { get; set; }
    public virtual IReadOnlyCollection<NoteEntity> Notes { get; set; }
}
