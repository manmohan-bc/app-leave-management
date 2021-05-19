using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveRequestViewModel
    {
        public int Id { get; set; }        
        public EmployeeViewModel RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        [Display(Name = "Approval State")]
        public bool? Approved { get; set; }
        public EmployeeViewModel ApprovedBy { get; set; }
        [Display(Name = "Approval Name")]
        public string ApprovedById { get; set; }
        public bool Cancelled { get; set; }

        [Display(Name = "Employee Comments")]
        [MaxLength(300)]
        public string RequestComment { get; set; }
    }

    public class AdminLeaveRequestViewViewModel
    {
        [Display(Name = "Total number of requests")]
        public int TotalRequests { get; set; }
        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }
        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }

    public class CreateLeaveRequestViewModel
    {
        [Display(Name = "Start Date")]
        [Required]
        //[DataType(DataType.Date)]                 // Commented after using bootstrap calender control
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        //[DataType(DataType.Date)]                 // Commented after using bootstrap calender control
        public DateTime EndDate { get; set; }
        
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
        
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public string RequestComment { get; set; }
    }

    public class EmployeeLeaveRequestViewViewModel
    {
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
