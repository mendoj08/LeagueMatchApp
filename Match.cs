using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Match
    {
        [JsonProperty("gameId")]
        public long GameId{ get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        [JsonProperty("queueId")]
        public int QueueId { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("teams")]
        public List<TeamStatistics> TeamStats { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentity> ParticipantIdentities { get; set; }

        public Match()
        {

        }

        public override string ToString()
        {
            SortParticipants();

            string str = $"GameID: {GameId} \nPlatformID: {PlatformId} \nGame creation time: {GameCreation} \nGame duration: {GameDuration} \n" +
                $"QueueId: {QueueId} \nSeason: {SeasonId} \nGame Version: {GameVersion} \nGame Mode: {GameMode} \nGame Type: {GameType}";

            /*
                $"\n\nBlue Team: \n{ParticipantIdentities[0].Player.SummonerName}\n{ ParticipantIdentities[1].Player.SummonerName}\n" +
                $"{ParticipantIdentities[2].Player.SummonerName}\n{ParticipantIdentities[3].Player.SummonerName}\n{ParticipantIdentities[4].Player.SummonerName}" +
                $"\n\nRed Team: \n{ParticipantIdentities[5].Player.SummonerName}\n{ParticipantIdentities[6].Player.SummonerName}\n{ParticipantIdentities[7].Player.SummonerName}" +
                $"\n{ParticipantIdentities[8].Player.SummonerName}\n{ParticipantIdentities[9].Player.SummonerName}";
            */

            string blue = $"\n\nBlue Team: ";
            for (int i = 0; i < 5; i++)
            {
                blue += $"\n{ParticipantIdentities[i].Player.SummonerName}";
            }

            string red = $"\n\nRed Team: ";
            for (int i = 5; i < 10; i++)
            {
                red += $"\n{ParticipantIdentities[i].Player.SummonerName}";
            }

            return str + blue + red + "\n";
        }

        /// <summary>
        /// Sets the TeamId property in each ParticipantIdentity object then separates the participant list
        /// into two teams.
        /// </summary>
        public void SortParticipants()
        {
            foreach (var participant in ParticipantIdentities)
            {
                var teamId = from p in Participants
                    where p.ParticipantId == participant.ParticipantId
                    select p.TeamId;

                participant.TeamId = teamId.ToList()[0];
            }

            ParticipantIdentities = ParticipantIdentities.OrderBy(p => p.TeamId).ToList();
        }
    }
}
