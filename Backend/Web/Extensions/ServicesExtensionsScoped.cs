using Business.Implementations;
using Business.Interfases;
using Data.Implementations;
using Data.Implements;
using Data.Interfases;
using Data.Repository;
using Entity.Dtos;
using Entity.Models;

namespace Web.Extensions
{
    public static class ServicesExtensionsScoped
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseData<>), typeof(BaseData<>));



            //Player 
            services.AddScoped<IBaseData<Player>, PlayerRepository>();
            services.AddScoped<IBaseBusiness<Player, PlayerDto>, PlayerBusiness>();

            //Room 
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IGameService, GameBusiness>();

            //Deck
            services.AddScoped<IDeckRepository, DeckRepositoriy>();
            services.AddScoped<IDeckService, DeckBusiness>();

            //Card
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IBaseBusiness<Card, CardDto>, CardBusiness>();

            //GamePlayer
            services.AddScoped<IBaseData<GamePlayer>, GamePlayerRepository>();
            services.AddScoped<IBaseBusiness<GamePlayer, GamePlayerDto>, GamePlayerBusiness>();

            //Move 
            services.AddScoped<IMoveRepository, MoveRepository>();
            services.AddScoped<IBaseBusiness<Move, MoveDto>, MoveService>();

            //Round
            services.AddScoped<IRounRepository, RounRepository>();
            services.AddScoped<IBaseBusiness<Round, RoundDto>, RounService>();

            return services;
        }
    }
}
