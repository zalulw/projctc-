namespace Tanc.Database.Entities
{
    public class CompetitionEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LocationId { get; set; }

        public virtual LocationEntity Location { get; set; }
        public virtual IReadOnlyCollection<TeamEntity> Teams { get; set; }
    }
}
