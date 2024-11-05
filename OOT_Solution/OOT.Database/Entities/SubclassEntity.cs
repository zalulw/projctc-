using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOT.Database.Entities
{
    public class SubclassEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Tribe")]
        public int TribeId { get; set; }

        public virtual TribeEntity Tribe { get; set; }
        
        public virtual IReadOnlyCollection<ClassEntity> BirdClass {  get; set; }
    }
}
