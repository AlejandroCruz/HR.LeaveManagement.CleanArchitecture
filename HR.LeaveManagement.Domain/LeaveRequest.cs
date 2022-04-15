﻿using HR.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain
{
    internal class LeaveRequest : BaseDomainEntity
    {
        public bool Cancelled { get; set; }
        public bool? Approved { get; set;}
        public DateTime DateActioned { get; set;}
        public DateTime DateRequest { get; set;}
        public DateTime EndDate { get; set;}
        public DateTime StartDate { get; set;}
        public int LeaveTypeId { get; set;}
        public LeaveType LeaveType { get; set;}
        public string RequestComments { get; set; }
    }
}
