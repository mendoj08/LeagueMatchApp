using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    public class MatchList
    {
        [JsonProperty("matches")]
        public List<Match> Matches { get; set; }

        public MatchList()
        {

        }
    }
}
