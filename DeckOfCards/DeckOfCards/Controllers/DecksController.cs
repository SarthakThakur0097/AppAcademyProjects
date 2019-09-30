using DeckOfCards.Data;
using DeckOfCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Http;
namespace DeckOfCards.Controllers
{
    [System.Web.Http.RoutePrefix("api/decks")]
    public class DecksController : ApiController
    {
        private IDeckRepository _repository;


        public DecksController(IDeckRepository repository)
        {
            _repository = repository;
        }

        async public Task<ShortDeckInfo> Post(DeckCreate creation)
        {
            int creationCount = creation.Count.HasValue ? creation.Count.Value : 1;
            Deck deck = await _repository.CreateNewShuffledDeckAsync(creationCount);
            ShortDeckInfo deckInfo = new ShortDeckInfo
            {
                DeckId = deck.DeckId,
                Remaining = deck.Cards.Where(x => !x.Drawn).Count()
            };
            return deckInfo;
        }
        [System.Web.Http.Route("{deckId}/piles/{pileName}")]
        async public Task<PileInfo> Patch(string deckId, string PileName, AddPileRequest pileRequest)
        {
            Deck deck = await _repository.PutCardsInPile(deckId, PileName, pileRequest.value);

            return new PileInfo
            {
                DeckId = deck.DeckId,
                Remaining = deck.Cards.Where(x => !x.Drawn).Count(),
                Piles = deck.Piles
            };
        }
        [System.Web.Http.Route("{deckId}/cards")]
        async public Task<CardDrawnResponse> Delete(string deckId, CardDrawRequest request)
        {
            int drawCount = request.Count.HasValue ? request.Count.Value : 1;
            Deck deck = await _repository.DrawCardsAsync(deckId, drawCount);
            List<CardInfo> cards = deck.Cards
              .Where(x => x.Drawn)
              .Reverse()
              .Take(drawCount)
              .Reverse()
              .Select(x => new CardInfo { Suit = x.Suit, Value = x.Value, Code = x.Code })
              .ToList();
            return new CardDrawnResponse
            {
                DeckId = deckId,
                Remaining = deck.Cards.Where(x => !x.Drawn).Count(),
                Removed = cards,
            };
        }

        [System.Web.Http.Route("{deckId}/piles/{pileName}")]
        async public Task<ShortPileInfo> Get(string deckId, string PileName)
        {

            Deck deck = await _repository.GetDeck(deckId);
            Pile myPile = await _repository.GetPile(deckId, PileName);

            List<CardInfo> cards = deck.Cards
              .Where(x => x.PileId == myPile.Id)
              .Select(x => new CardInfo { Suit = x.Suit, Value = x.Value, Code = x.Code })
              .ToList();

            return new ShortPileInfo
            {
                DeckId = deckId,
                Remaining = deck.Cards.Where(x => !x.Drawn).Count(),
                PileName = myPile.Name,
                Cards = cards
            };
        }
    }
}
