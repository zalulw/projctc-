using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOT.Database.Entities
{
    public class SpeciesEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Class")]
        public int ClassId { get; set; }


        public virtual IReadOnlyCollection<ClassEntity> Class { get; set; }
        public virtual BirdEntity Bird { get; set; }
    }
}
