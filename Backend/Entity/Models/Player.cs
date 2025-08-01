using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Player : BaseModel
    {
        public string Name { get; set; }

        public List<GamePlayer>? GamePlayers { get; set; }
    }
}
