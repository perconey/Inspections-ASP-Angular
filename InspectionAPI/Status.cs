using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Status
    {

        public Int32 Id { get; set; }

        [StringLength(20)]
        public String StatusOption { get; set; }
    
    
    }
}
