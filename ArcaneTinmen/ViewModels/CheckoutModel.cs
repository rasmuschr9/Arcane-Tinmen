using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArcaneTinmen.ViewModels
{
    public class CheckoutModel
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [RegularExpression(@"\S+@(\S+\.)+\w{2,4}",
        ErrorMessage = "We do not recognize this email-address")]
        [Required]
        public string Email { get; set; }

        [RegularExpression(@"\S+@(\S+\.)+\w{2,4}",
        ErrorMessage = "We do not recognize this email-address")]
        [Compare("Email", ErrorMessage = "The email and confirmation do not match.")]
        [Required]
        public string ConfirmEmail { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Zip { get; set; }
    }
}