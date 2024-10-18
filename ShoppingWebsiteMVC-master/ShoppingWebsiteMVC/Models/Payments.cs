using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Web.ModelBinding;
using System.ComponentModel;

namespace ShoppingWebsiteMVC.Models
{
    public class Payments
    {
        [Key]
        [Required(ErrorMessage ="Card Number is required")]
        [MaxLength(16)]
        [MinLength(16)]
        [RegularExpression(@"^\d{16}$", ErrorMessage ="Enter valid card number")]
        [DisplayName("CARD NUMBER")]
        public string Card_Number { get; set; }
        [Required(ErrorMessage ="Espiry Date required")]
        [MaxLength(5)]
        [MinLength(5)]
        [RegularExpression(@"^\d{2}/\d{2}$", ErrorMessage ="Enter valid card Date(MM/DD) eg.13/78")]
        [DisplayName("DATE")]
        public string Espiry_Date { get; set; }
        [Required(ErrorMessage ="Email required")]
        [EmailAddress(ErrorMessage ="Enter Valid email")]
        [RegularExpression(@"^[^@\s]+@[^@^\s]+\.(com|ac.za)$", ErrorMessage = "Enter Valid email")]
        [DisplayName("EMAIL")]
        public string Email { get; set; }
        [Required(ErrorMessage ="VCC number required")]
        [MaxLength(3)]
        [MinLength(3)]
        [DisplayName("VCC")]
        [RegularExpression(@"^\d{3}$")]
        public string VCC { get; set; }
    }
}