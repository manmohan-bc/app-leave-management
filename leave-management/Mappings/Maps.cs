using AutoMapper;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, Models.LeaveTypeViewModel>().ReverseMap();            

            CreateMap<LeaveHistory, Models.LeaveHistoryViewModel>().ReverseMap();
            
            CreateMap<LeaveAllocation, Models.LeaveAllocationViewModel>().ReverseMap();
            
            CreateMap<Employee, Models.EmployeeViewModel>().ReverseMap();
        }
    }
}
