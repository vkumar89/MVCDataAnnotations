using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDataAnnotations.Models
{
    public class User
    {
        [Required]
        [Display(Name ="User Name")]
        [RegularExpression(@"[A-Za-z\s]{3,}", ErrorMessage = "Name can have alphabets & spaces with min size of 3.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage ="Enter Valid Mail id")]
        public string Email { get; set; }

        [Required]
       // [RegularExpression(@"[^[a-zA-Z0-9]",ErrorMessage ="Enter correct Pwd")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Required (ErrorMessage ="Field can't be empty")]
        [Compare("Password", ErrorMessage = "Confirm password should match with password.")]
        public string ConfirmPassword { get; set; }

    }
}