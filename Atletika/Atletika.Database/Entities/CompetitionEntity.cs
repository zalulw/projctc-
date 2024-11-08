﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atletika.Database.Entities
{
    public class CompetitionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
        [Required]
        [StringLength(16)]
        public string StartDate { get; set; }
        [Required]
        [StringLength(16)]
        public string EndDate { get; set; }
        [Required]
        public uint Year { get; set; }

        [ForeignKey("Street")]
        public int StreetId { get; set; }
        public virtual StreetEntity Street { get; set; }

        public virtual IReadOnlyCollection<ClubEntity> Clubs { get; set; }

        public virtual IReadOnlyCollection<EventEntity> Events { get; set; }
    }
}
