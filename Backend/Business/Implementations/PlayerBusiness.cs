using Business.Implementations.Base;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class PlayerBusiness : BaseBusiness<Player, PlayerDto>
    {
        public PlayerBusiness(IBaseData<Player> data) : base(data)
        {
        }
    }
}
