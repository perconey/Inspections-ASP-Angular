using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        public Int32 Id { get; set; }

        [StringLength(20)]
        public String InspectionName { get; set; } = String.Empty;


    }
}
