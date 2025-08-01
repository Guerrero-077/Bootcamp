using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class CardDto : BaseModel
    {
        public int Code { get; set; }
        public int Force { get; set; }
        public int Speed { get; set; }
        public int Popularity { get; set; }
        public int Appearances { get; set; }
        public int IQ { get; set; }

        public int DeckId { get; set; }

    }
}
