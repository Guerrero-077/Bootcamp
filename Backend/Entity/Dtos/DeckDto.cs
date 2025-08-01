using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class DeckDto : BaseModel
    {
        public int GamePlayerId { get; set; }


        public bool Active { get; set; }
    }
}
