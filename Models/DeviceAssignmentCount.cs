using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingSystem.API.Models
{
    public class DeviceAssignmentCount
    {
        [Column("devicecode")]
        public string DeviceCode { get; set; }

        [Column("devicename")]
        public string? DeviceName { get; set; } 

        [Column("totalusages")]
        public int TotalUsages { get; set; }
    }


}
