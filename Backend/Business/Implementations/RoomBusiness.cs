using Business.Implementations.Base;
using Business.Interfases;
using Data.Implements;
using Data.Interfases;
using Entity.Dtos;
using Entity.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class RoomBusiness : BaseBusiness<Room, RoomDto>, IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly ICardRepository _cardRepository;
        private readonly IDeckRepository _deckRepository;
        public RoomBusiness(IRoomRepository data, ICardRepository cardRepository, IDeckRepository deckRepository) : base(data)
        {
            _roomRepository = data;
            _cardRepository = cardRepository;
            _deckRepository = deckRepository;
        }






        public async Task<GameStartResultDto> StartGameAsync(int roomId)
        {
            var room = await _roomRepository.GetWithPlayersAsync(roomId);

            ValidateRoom(room);

            var allCards = await _cardRepository.GetAll();
            var shuffled = allCards.OrderBy(_ => Guid.NewGuid()).ToList();

            ValidateCardAvailability(room.GamePlayers.Count, shuffled.Count);

            foreach (var player in room.GamePlayers)
            {
                var playerCards = GetPlayerDeck(shuffled, player.Id);
                await _deckRepository.AddRangeAsync(playerCards);
            }

            await _roomRepository.Update(room); 


            var fullDecks = await _deckRepository.GetDecksByRoomWithCardAndPlayer(roomId);

            // Agrupar por GamePlayer y mapear
            var grouped = fullDecks
                .GroupBy(d => d.GamePlayerId)
                .Select(group =>
                {
                    var first = group.First();
                    return new GamePlayerWithCardsDto
                    {
                        GamePlayerId = first.GamePlayerId,
                        PlayerName = first.GamePlayer!.Player!.Name,
                        Player = first.GamePlayer.Player.Adapt<PlayerDto>(),
                        Cards = group.Select(d => d.Card!.Adapt<CardDto>()).ToList()
                    };
                }).ToList();

            return new GameStartResultDto
            {
                Success = true,
                RoomId = room.Id,
                Players = grouped
            };
        }






        private void ValidateRoom(Room room)
        {
            if (room == null)
                throw new Exception("La sala no existe.");

            int count = room.GamePlayers.Count;
            if (count < 2 || count > 7)
                throw new Exception("Número inválido de jugadores");
        }

        private void ValidateCardAvailability(int playerCount, int totalCards)
        {
            if (totalCards < playerCount * 8)
                throw new Exception("No hay suficientes cartas disponibles.");
        }

        private List<Deck> GetPlayerDeck(List<Card> shuffledCards, int gamePlayerId)
        {
            var deck = new List<Deck>();
            for (int i = 0; i < 8; i++)
            {
                var card = shuffledCards[0];
                shuffledCards.RemoveAt(0);

                deck.Add(new Deck
                {
                    GamePlayerId = gamePlayerId,
                    CardId = card.Id,
                    Active = true
                });
            }

            return deck;
        }



    }
}
