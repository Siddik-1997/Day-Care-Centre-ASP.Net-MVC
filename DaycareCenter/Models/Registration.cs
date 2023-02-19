using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DaycareCenter.Models
{
    public class Registration
    {
        [Key]
        [Required(ErrorMessage = "User ID is Required.")]
        [Display(Name = "User ID")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password.")]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Confirm required password ")]
        [Display(Name = "Confirm Password.")]
        [Compare("Pass")]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string RePass { get; set; }

    }
}
