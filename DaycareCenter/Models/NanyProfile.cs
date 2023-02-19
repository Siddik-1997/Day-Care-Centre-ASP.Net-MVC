using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareCenter.Models
{
    public class NanyProfile
    {
        [Key]
        [Required(ErrorMessage = "Nany ID is Required.")]
        [Display(Name = "Nany Id")]
        public int Nany_Id { get; set; }




        [Required(ErrorMessage = "Nany Name Required.")]
        [Display(Name = "Nany Name")]
        public string Nany_Name { get; set; }


        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Age")]
        public string NAge { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender")]
        public string NGender { get; set; }

        [Required(ErrorMessage = "Religion is required")]
        [Display(Name = "Religion")]
        public string NReligion { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string NPhone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string NAddress { get; set; }

    }
}
