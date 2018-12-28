using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    public class ParticipantTimeline
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        // 4 Values stored in Deltas Maps:
        // 0-10 min, 10-20 min, 20-30 min, and 30 min-end
        [JsonProperty("creepsPerMinDeltas")]
        public Dictionary<String,double> CreepsPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public Dictionary<String, double> XpPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public Dictionary<String, double> GoldPerMinDeltas { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public Dictionary<String, double> CsDiffPerMinDeltas { get; set; }

        [JsonProperty("xpDiffPerMinDeltas")]
        public Dictionary<String, double> XpDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public Dictionary<String, double> DamageTakenPerMinDeltas { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public Dictionary<String, double> DamageTakenDiffPerMinDeltas { get; set; }

        // Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT
        [JsonProperty("role")]
        public string Role { get; set; }

        // Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM
        // MID and BOT are legacy values
        [JsonProperty("lane")]
        public string Lane { get; set; }

        public ParticipantTimeline()
        {

        }
    }
}
