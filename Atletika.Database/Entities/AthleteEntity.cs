﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class AthleteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
        [Required]
        [StringLength(16)]
        public string Gender { get; set; }
        [Required]
        [StringLength(16)]
        public string DateOfBirth { get; set; }

        [StringLength(16)]
        public string ResponsiblePersonName { get; set; }
        [StringLength(16)]
        public string ResponsiblePersonPhone { get; set; }

        [ForeignKey("Club")]
        public uint ClubId { get; set; }
        public virtual ClubEntity Club { get; set; }

        [ForeignKey("Street")]
        public uint StreetId { get; set; }
        public virtual StreetEntity Street { get; set; }
    }
}
