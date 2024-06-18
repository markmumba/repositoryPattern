namespace repositoryPattern.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAllData();
        Task<T> GetDataById(int id);
        Task<T> AddNewData(T entity);
        Task<T> UpdateDataById(T entity);
        Task<T> DeleteData(int id);
    }
}
