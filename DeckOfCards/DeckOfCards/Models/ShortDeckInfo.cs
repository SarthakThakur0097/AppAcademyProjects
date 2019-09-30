using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DeckOfCards.Models
{
    public class ShortDeckInfo
    {
        public string DeckId
        {
            get; set;
        }

        public int Remaining
        {
            get; set;
        }

    }
}