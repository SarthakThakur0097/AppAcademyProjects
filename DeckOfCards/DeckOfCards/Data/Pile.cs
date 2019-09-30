using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeckOfCards.Data
{
    [Table("Pile")]
    public class Pile
    {
        public Pile()
        {
            Cards = new List<Card>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public int DeckId { get; set; }
        public Deck Deck { get; set; }

        public IList<Card> Cards { get; set; }
    }
}