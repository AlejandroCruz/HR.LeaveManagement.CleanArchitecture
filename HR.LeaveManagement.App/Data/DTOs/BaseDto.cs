namespace HR.LeaveManagement.App.Data.DTOs
{
    public interface IBaseDto
    {
        int Id { get; set; }
    }

    public class BaseDto : IBaseDto
    {
        public int Id { get; set; }
    }
}
