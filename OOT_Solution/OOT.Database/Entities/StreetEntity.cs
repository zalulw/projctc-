using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOT.Database.Entities
{
    public class StreetEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }

        public virtual IReadOnlyCollection<CityEntity> City { get; set; }

        public virtual MemberEntity Member { get; set; }
    }
}
