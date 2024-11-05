using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOT.Database.Entities
{
    public class NoteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Bird")]
        public int BirdId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Date { get; set; } 

        public virtual IReadOnlyCollection<BirdEntity> Bird { get; set; }
        public virtual IReadOnlyCollection<MemberEntity> Member { get; set; }

    }
}
