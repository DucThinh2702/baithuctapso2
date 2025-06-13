using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingSystem.API.Models
{
    public class AssignmentUsage
    {
        [Column("devicecode")]
        public string DeviceCode { get; set; }

        [Column("totalassignments")]
        public int TotalAssignments { get; set; }

        [Column("year")]
        public double Year { get; set; }

        [Column("month")]
        public double Month { get; set; }

        [Column("week")]
        public double Week { get; set; }
    }

}
