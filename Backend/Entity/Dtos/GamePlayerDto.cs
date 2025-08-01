using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class GamePlayerDto : BaseModel
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }

        public int RoomId { get; set; }
        public bool Winner { get; set; }
    }
}
