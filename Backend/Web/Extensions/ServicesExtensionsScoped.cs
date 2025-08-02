using Business.Implementations;
using Business.Interfases;
using Data.Implements;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;

namespace Web.Extensions
{
    public static class ServicesExtensionsScoped
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {

            //Player 
            services.AddScoped<IBaseData<Player>, PlayerRepository>();
            services.AddScoped<IBaseBusiness<Player, PlayerDto>, PlayerBusiness>();

            //Room 
            services.AddScoped<IBaseData<Room>, RoomRepository>();
            services.AddScoped<IBaseBusiness<Room, RoomDto>, RoomBusiness>();

            //Deck
            services.AddScoped<IBaseData<Deck>, DeckRepositoriy>();
            services.AddScoped<IBaseBusiness<Deck, DeckDto>, DeckBusiness>();

            //Card
            services.AddScoped<IBaseData<Card>, CardRepository>();
            services.AddScoped<IBaseBusiness<Card, CardDto>, CardBusiness>();

            //GamePlayer
            services.AddScoped<IBaseData<GamePlayer>, GamePlayerRepository>();
            services.AddScoped<IBaseBusiness<GamePlayer, GamePlayerDto>, GamePlayerBusiness>();

            return services;
        }
    }
}
