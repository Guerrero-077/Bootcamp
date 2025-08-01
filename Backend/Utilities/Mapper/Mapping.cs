using Entity.Dtos;
using Entity.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Mapper
{
    public static class Mapping
    {
        public static void MappingConfiguration()
        {
            TypeAdapterConfig<CardDto, Card>.NewConfig().TwoWays();
            TypeAdapterConfig<PlayerDto, Player>.NewConfig().TwoWays();
            TypeAdapterConfig<RoomDto, Room>.NewConfig().TwoWays();
            TypeAdapterConfig<DeckDto, Deck>.NewConfig().TwoWays();
            TypeAdapterConfig<GamePlayerDto, GamePlayer>.NewConfig().TwoWays();

        }

    }
}
