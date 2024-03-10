using System.Collections.Generic;

namespace MotivationalQuoteChanger.classes
{
    public class Authors
    {
        private List<string> authors = new List<string>()
        {
            "- Albert Einstein",
            "- C.S. Lewis",
            "- Steve Jobs",
            "- Sam Levenson",
            "- Theodore Roosevelt",
            "- Steve Jobs"
        };

        public List<string> GetAllAuthors()
        {
            return authors;
        }
    }
}