using System.ComponentModel.DataAnnotations.Schema;

namespace Tanc.Database.Entities
{
    public class DateEntity
    {
        public int Id { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}
