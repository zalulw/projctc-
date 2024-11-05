using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOT.Database.Entities
{
    public class ClassEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Subclass")]
        public int SubclassId { get; set; }

        public virtual SubclassEntity Species { get; set; }

        public virtual IReadOnlyCollection<ClassEntity> Subclass { get; set; }
    }
}
