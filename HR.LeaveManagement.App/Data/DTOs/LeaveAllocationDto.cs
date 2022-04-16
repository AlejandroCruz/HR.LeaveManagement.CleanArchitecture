using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.App.Data.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int LeaveTypeId { get; set; }
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public LeaveTypeDto LeaveType { get; } // You don't let the DTO know about the Domain (LeaveType)
    }
}
