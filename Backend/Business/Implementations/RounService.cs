using Business.Implementations.Base;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;

namespace Business.Implementations
{
    public class RounService : BaseBusiness<Round, RoundDto>
    {
        public RounService(IRounRepository data) : base(data)
        {
        }
    }
}
