using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain.Common
{
    // internal can be accessed by any in same assembly, but not from another assembly.
    public abstract class BaseDomainEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime DateLastModified { get; set; }
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
