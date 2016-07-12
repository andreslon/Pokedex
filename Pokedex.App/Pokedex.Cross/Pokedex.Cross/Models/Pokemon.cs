using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Cross.Models
{
    public  class Pokemon
    {
        public string id { get; set; }
        public string name { get; set; }
        public string species { get; set; }
        public List<string> type { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public List<string> abilities { get; set; }
        public List<object> evolution { get; set; }
    }
}
