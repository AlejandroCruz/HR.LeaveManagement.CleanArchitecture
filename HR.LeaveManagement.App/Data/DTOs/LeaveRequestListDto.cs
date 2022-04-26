using HR.LeaveManagement.App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.App.Data.DTOs
{
    public class LeaveRequestListDto : BaseDto
    {
        public bool? Aproved { get; set; }
        public DateTime DateRequested { get; set; }
        //public DateTime EndDate { get; set; }
        //public DateTime StartDate { get; set; }
        //public Employee Employee { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        //public string RequestingEmployeeId { get; set; }
    }
}
