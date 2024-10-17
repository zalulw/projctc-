using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tanc.Database.Entities;
[Table("City")]
public class CityEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int PostalCode { get; set; }

    [Required]
    [StringLength(16)]
    public string CityName { get; set; }

    [ForeignKey("Country")]
    public uint CountryId { get; set; }
    public virtual CountryEntity Country { get; set; } //navigation property
}
