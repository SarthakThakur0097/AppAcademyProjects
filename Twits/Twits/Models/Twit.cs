using System;

namespace Twits.Models
{
    public class Twit
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTimeOffset CreatedOn { get; internal set; }
    }
}