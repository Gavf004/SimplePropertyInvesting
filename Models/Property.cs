

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePropertyInvesting.Models
{
    public class Property
    {
        [Key]
        [DisplayName("Property ID")]
        public int Property_Id { get; set; }
        [Required]
        [DisplayName("Address 1")]
        public string Address1 { get; set; }
        [Required]
        [DisplayName("Address 2")]
        public string Address2 { get; set; }
        [DisplayName("Address 3")]
        public string Address3 { get; set; }
        [Required]
        [DisplayName("Eircode")]
        public string Eircode { get; set; }

        [Required]
        [DisplayName("Property Value")]
        public float Property_Value { get; set; }

        [Required]
        [DisplayName("Purchase Price")]
        public float Purchase_Price { get; set; }

        [Required]
        [DisplayName("Purchase Date")]
        public DateTime Purchase_Date { get; set; }

        // Maybe split into smaller class
        [Required]
        [DisplayName("Property Tax per year")]
        public float Property_Tax { get; set; }

        [Required]
        [DisplayName("Property Insurance per year")]
        public float Property_Insurance { get; set; }

        // Will be populated by user inputing rental receipts.
        [DisplayName("Monthly Rental Income")]
        public float Monthly_Rental_Income { get; set; }

        [DisplayName("Total expenditure")]
        public float Total_Expenditure { get; set; }

        [DisplayName("Monthly Mortgage Repayments")]
        public float Monthly_Mortgage_Payment { get; set; }












        //navigation properties
        public virtual int UserID { get; set; }
        //public User User { get; set; }

        public ICollection<Unit> Units { get; set; }



    }
}
