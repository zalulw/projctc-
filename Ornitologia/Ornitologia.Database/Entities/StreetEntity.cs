using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornitologia.Database.Entities;
[Table("Street")]
public class StreetEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public int PostalCode { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber { get; set; }
    [ForeignKey("City")]
    public int CityId { get; set; }
    public virtual CityEntity City { get; set; } //nav
    public virtual MemberEntity Member { get; set; }
    public virtual IReadOnlyCollection<NoteEntity> Notes { get; set; }
}
