using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareCenter.Models
{
    public class NanySchedule
    {
        [Key]
        [Required(ErrorMessage = "ID is Required.")]
        [Display(Name = " Schedule Id")]
        public int Schedule_Id { get; set; }

        [Required(ErrorMessage = "Shift ID is Required.")]
        [Display(Name = "Shift Id")]
        public int Shift_Id { get; set; }

        [Required(ErrorMessage = "Nany ID is Required.")]
        [Display(Name = "Nany Id")]
        public int Nany_Id { get; set; }

        [Required(ErrorMessage = "Child ID is Required.")]
        [Display(Name = "Child Id")]
        public int Child_Id { get; set; }

       


    }
}
