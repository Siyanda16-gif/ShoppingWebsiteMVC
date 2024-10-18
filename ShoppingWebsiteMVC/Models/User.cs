using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWebsiteMVC.Models
{
    public class User
    {
        [Key]
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[^@\s]+@[^@^\s]+\.(com|ac.za)$", ErrorMessage = "Enter Valid email")]
        [Display(Name = "Email address")]
        public string UserId { get; set; }
        [Required(ErrorMessage="Please Enter name")]
        [Display(Name = "Firstname")]
        [RegularExpression(@"^[a-zA-Z\s\-]+$",ErrorMessage="Enter valid Name")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Lastname")]
        [RegularExpression(@"^[a-zA-Z\s\-]+$", ErrorMessage = "Enter valid Surname")]
        public string Lastname { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(255,ErrorMessage ="Password should be minimum of 8 characters",MinimumLength =8)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and should contain : upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string Password { get; set; }
        
        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password required")]
        [Copmpare("Password",ErrorMessage="Password do not match")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Display(Name = "ContactNumber")]
        [Required(ErrorMessage = "Contact number is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Your mobile number  is not valid")]
        [RegularExpression(@"^(\+27|0)[6-8][0-9]{8}$")]
        public string ContactNumber { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        [RegularExpression(@"^[a-zA-Z\s\-]+$", ErrorMessage = "Enter valid City name")]
        public string City { get; set; }
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}