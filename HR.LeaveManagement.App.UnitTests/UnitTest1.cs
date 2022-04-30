using HR.LeaveManagement.App.Data.DTOs;
using Xunit;

namespace HR.LeaveManagement.App.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var leaveRequestDto = new LeaveRequestDto();
            IChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto = new LeaveRequestDto { Approved = true };

            int propFromBase = leaveRequestDto.Id = 1;
            bool? mapFromInterface = changeLeaveRequestApprovalDto.Approved;

            Assert.True(mapFromInterface);
        }
    }
}