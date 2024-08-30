namespace Bot.Core.Service
{
    public interface IService<T> where T : class
    {
        T? GetById(int id);
        IEnumerable<T> GetAll();
        void Save(T entity);
        void Remove(T entity);
    }
}
