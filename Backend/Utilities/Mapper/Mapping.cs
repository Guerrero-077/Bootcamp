using Entity.Dtos;
using Entity.Models;
using Mapster;

namespace Utilities.Mapper
{
    public static class Mapping
    {
        public static void MappingConfiguration()
        {
            TypeAdapterConfig<CardDto, Card>.NewConfig().TwoWays();
            TypeAdapterConfig<PlayerDto, Player>.NewConfig().TwoWays();
            //TypeAdapterConfig<GamePlayerDto, GamePlayer>.NewConfig().TwoWays();

            //TypeAdapterConfig<GamePlayer, GamePlayerWithCardsDto>.NewConfig().TwoWays();


            //TypeAdapterConfig<DeckDto, Deck>.NewConfig().TwoWays();
            TypeAdapterConfig<Deck, DeckDto>.NewConfig()
                .Map(dest => dest.GamePlayerId, src => src.GamePlayer.Id)
                .Map(dest => dest.PlayerName, src => src.GamePlayer.Player.Name);

            TypeAdapterConfig<GameDto, Game>.NewConfig().TwoWays();

        }

    }
}
