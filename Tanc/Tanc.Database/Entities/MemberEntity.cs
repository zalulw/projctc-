using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanc.Database.Entities
{
    public class MemberEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Sex { get; set; }


        public DateTime Date { get; set; }

        [Required]
        public string Residence { get; set ;}

        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual TeamEntity Team { get; set; }
    }
}
