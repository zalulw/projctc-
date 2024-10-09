namespace Tanc.Database.Entities;

[Table("Location")]
[Index(nameof(PostalCode), IsUnique = true)]
public class LocationEntity
{
    [Required]
    public uint PostalCode { get; set; }

    [Required]
    [StringLength(16)]
    public string CountryName { get; set; }

    [Required]
    [StringLength(16)]
    public string CityName { get; set; }

    [Required]
    [StringLength(16)]
    public string StreetName { get; set; }

    [Required]
    public uint HouseNumber { get; set; }
}
