namespace TrainingSystem.API.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ServiceStats
    {
        [Column("servicecode")]
        public string ServiceCode { get; set; }

        [Column("servicename")]
        public string ServiceName { get; set; }

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
