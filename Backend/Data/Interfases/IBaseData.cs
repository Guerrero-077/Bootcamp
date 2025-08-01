using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfases
{
    public interface IBaseData<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Save(T entity);
        Task<T> Update(T entity);
        Task<int> Delete(int id);
    }
}
