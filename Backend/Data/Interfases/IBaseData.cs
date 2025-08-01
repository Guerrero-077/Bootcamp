using Entity.Models.Base;

namespace Data.Interfases
{
    public interface IBaseData<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T> Save(T entity);
        Task<T?> Update(T entity);
        Task<int?> Delete(int id);
    }
}
