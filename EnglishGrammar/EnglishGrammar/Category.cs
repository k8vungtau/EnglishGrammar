using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammar
{
    public class Category
    {
        public int id { get; set; }
        public string title { get; set; }
        public string imageURL { get; set; }
        public List<String> pageName { get; set; }
        public List<String> pageURL { get; set; }

        public Category() { }

    }
}
