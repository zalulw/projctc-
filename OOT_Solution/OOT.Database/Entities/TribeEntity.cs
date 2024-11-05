using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOT.Database.Entities
{
    public class TribeEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual SubclassEntity Subclass { get; set; }
    }
}
