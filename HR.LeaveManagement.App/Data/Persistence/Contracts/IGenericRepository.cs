namespace HR.LeaveManagement.App.Data.Persistence.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Delete(T entity);
        Task<bool> Exists(int id);
        Task<T> Get(int id);
        Task<T> Update(T entity);
    }
}
