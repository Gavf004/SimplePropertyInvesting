using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePropertyInvesting.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        [Required,DisplayName("Unit Name")]
        public string UnitName { get; set; }

        


        //navigation properties

        public ICollection<Tenant> Tenants { get; set; }
        public int Property_Id { get; set; }


    }
}
