using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Inspection
    {
        public Int32 Id { get; set; }

        [StringLength(20)]
        public String Status { get; set; }

        [StringLength(200)]
        public String Comments { get; set; }

        public Int32 InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }

    }
}
