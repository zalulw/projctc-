using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tanc.Database.Entities;
[Table("Country")]
public class CountryEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(16)]
    public string CountryName { get; set; }
}
