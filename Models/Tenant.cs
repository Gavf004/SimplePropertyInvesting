using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePropertyInvesting.Models
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }
        [Required]
        [DisplayName("Tenant Name")]
        public string TenantName { get; set; }
        [Required,DisplayName("Contract Start Date")]
        public DateTime ContractStartDate { get; set; }
        [Required, DisplayName("Contract End Date")]
        public DateTime ContractEndDate { get; set; }
        
        [Required]
        [DisplayName("Passport NUmber")]
        public string PassportNumber { get; set; }

        //Navigation Property
        public int UnitId { get; set; }



    }
}
