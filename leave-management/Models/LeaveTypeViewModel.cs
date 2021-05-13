using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Default No. Of. Days")]
        [Range(1, 25, ErrorMessage = "Please enter valid no.")]
        public int DefaultDays { get; set; }
        [Display(Name="Date Created")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateCreated { get; set; }
    }
}
