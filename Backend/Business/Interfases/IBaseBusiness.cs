using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfases
{
    public interface IBaseBusiness<T, D>
    {
        Task<IEnumerable<D>> GetAll();
        Task<D> GetById(int id);
        Task<D> Save(D entity);
        Task<D> Update(D entity);
        Task<int?> Delete(int id);
    }
}
