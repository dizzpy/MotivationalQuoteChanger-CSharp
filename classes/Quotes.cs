using System.Collections.Generic;

namespace MotivationalQuoteChanger.classes
{
    public class Quotes
    {
        private List<string> quotes = new List<string>()
        {
            "In the middle of difficulty lies opportunity.",
            "You are never too old to set another goal or to dream a new dream.",
            "The only way to do great work is to love what you do.",
            "Don't watch the clock; do what it does. Keep going.",
            "Believe you can and you're halfway there.",
            "The only way to do great work is to love what you do."
        };

        public List<string> GetAllQuotes()
        {
            return quotes;
        }
    }
}