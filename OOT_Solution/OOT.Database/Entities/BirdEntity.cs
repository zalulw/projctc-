using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOT.Database.Entities
{
    public class BirdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RingNumber { get; set; }
        [ForeignKey("Species")]
        public int SpeciesId { get; set; }
        [Required]
        public string WhoRinged { get; set; }
        [Required]
        public string WhereRinged { get; set; }
        [Required]
        public string DateOfRinging { get; set; }

        public IReadOnlyCollection<SpeciesEntity> Species { get; set; }   
    }
}
