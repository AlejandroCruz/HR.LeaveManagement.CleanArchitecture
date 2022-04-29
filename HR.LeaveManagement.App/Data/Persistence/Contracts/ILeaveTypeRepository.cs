using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.App.Data.Persistence.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        //Task<LeaveType> GetLeaveTypeWithDetails(int id);
        //Task<List<LeaveType>> GetLeaveTypeWithDetails();
    }
}
