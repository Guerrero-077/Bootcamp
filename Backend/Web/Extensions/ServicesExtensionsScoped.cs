using Business.Implementations;
using Business.Interfases;
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
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped <IRoomService, RoomBusiness>();

            //Deck
            services.AddScoped<IDeckRepository, DeckRepositoriy>();
            services.AddScoped<IDeckService, DeckBusiness>();

            //Card
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IBaseBusiness<Card, CardDto>, CardBusiness>();

            //GamePlayer
            services.AddScoped<IBaseData<GamePlayer>, GamePlayerRepository>();
            services.AddScoped<IBaseBusiness<GamePlayer, GamePlayerDto>, GamePlayerBusiness>();

            return services;
        }
    }
}
