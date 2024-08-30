namespace Bot.Core.src.DAO.Interface
{
    public interface IGenericDAO<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        T? GetById(int id);
        IEnumerable<T> GetAll();
        void Remove(T entity);
    }
}
