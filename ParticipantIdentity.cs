using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    public class ParticipantIdentity
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        // Not from JSON file
        public int TeamId { get; set; }

        [JsonProperty("player")]
        public PlayerInfo Player { get; set; }

        public ParticipantIdentity()
        {

        }
    }
}
