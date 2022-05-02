using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Validators
{
    public class CreateLeaveTypeValid : AbstractValidator<ILeaveTypeDto>
    {
        public CreateLeaveTypeValid()
        {
            Include(new LeaveTypeValid());
        }

    }
}
