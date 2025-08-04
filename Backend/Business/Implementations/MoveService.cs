using Business.Implementations.Base;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;

namespace Business.Implementations
{
    public class MoveService : BaseBusiness<Move, MoveDto>
    {
        public MoveService(IBaseData<Move> data) : base(data)
        {
        }
    }
}
