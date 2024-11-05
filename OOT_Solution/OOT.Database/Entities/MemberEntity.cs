using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOT.Database.Entities
{
    public class MemberEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MembershipCardNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Street")]
        public int AddressId { get; set; }
        [Required]
        public string StartOfMembership { get; set; }
        [Required]
        public string EndOfMembership { get; set;}

        public virtual IReadOnlyCollection<StreetEntity> Street { get; set; }
        public virtual NoteEntity Note { get; set; }
    }
}
