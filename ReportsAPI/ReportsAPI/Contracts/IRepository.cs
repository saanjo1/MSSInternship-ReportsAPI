namespace ReportsAPI.Contracts
{
    public interface IRepository<T>
    {
        Task<int> CountAsync();
    }
}
