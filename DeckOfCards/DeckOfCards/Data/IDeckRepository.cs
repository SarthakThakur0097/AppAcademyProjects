using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DeckOfCards.Data
{
    public interface IDeckRepository
    {
        Task<Deck> CreateNewShuffledDeckAsync(int deckCount);
        Task<Deck> DrawCardsAsync(string deckId, int numberToDraw);
        Task<Deck> GetDeck(string deckId);
        Task<Deck> PutCardsInPile(string deckId, string pileName, List<string> cardCodes);
        Task<Pile> GetPile(string deckId, string pileName);
       
    }
}
