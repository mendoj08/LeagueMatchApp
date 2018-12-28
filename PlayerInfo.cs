using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    public class PlayerInfo
    {
        // Region/Server
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }

        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }

        [JsonProperty("currentAccountId")]
        public int CurrentAccountId { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistory { get; set; }

        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }
    }
}
