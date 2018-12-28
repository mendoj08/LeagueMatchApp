using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    public class ParticipantStats
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("item0")]
        public int Item0 { get; set; }

        [JsonProperty("item1")]
        public int Item1 { get; set; }

        [JsonProperty("item2")]
        public int Item2 { get; set; }

        [JsonProperty("item3")]
        public int Item3 { get; set; }

        [JsonProperty("item4")]
        public int Item4 { get; set; }

        [JsonProperty("item5")]
        public int Item5 { get; set; }

        [JsonProperty("item6")]
        public int Item6 { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }

        [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }

        [JsonProperty("longestTimeSpentLiving")]
        public int LongestTimeSpentLiving { get; set; }

        [JsonProperty("doubleKills")]
        public int DoubleKills { get; set; }

        [JsonProperty("tripleKills")]
        public int TripleKills { get; set; }

        [JsonProperty("quadraKills")]
        public int QuadraKills { get; set; }

        [JsonProperty("pentaKills")]
        public int PentaKills { get; set; }

        [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }

        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike{ get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [JsonProperty("totalHeal")]
        public long TotalHealing { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }

        [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }

        [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [JsonProperty("magicalDamageTaken")]
        public long MagicDamageTaken { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }

        [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }

        [JsonProperty("turretKills")]
        public int TurretKills { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("totalMinionsKilled")]
        public int TotalMinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilledTeamJungle")]
        public int NeutralMinionsKilledTeamJungle { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int NeutralMinionsKilledEnemyJungle { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("champLevel")]
        public int ChampLevel { get; set; }

        [JsonProperty("visionWardsBoughtInGame")]
        public int VisionWardsBoughtInGame { get; set; }

        [JsonProperty("sightWardsBoughtInGame")]
        public int SightWardsBoughtInGame { get; set; }

        [JsonProperty("wardsPlaced")]
        public int WardsPlaced { get; set; }

        [JsonProperty("wardsKilled")]
        public int WardsKilled { get; set; }

        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [JsonProperty("firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        [JsonProperty("firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }

        [JsonProperty("combatPlayerScore")]
        public int CombatPlayerScore { get; set; }

        [JsonProperty("objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }

        [JsonProperty("totalPlayerScore")]
        public int TotalPlayerScore { get; set; }

        [JsonProperty("totalScoreRank")]
        public int TotalScoreRank { get; set; }

        [JsonProperty("playerScore0")]
        public int PlayerScore0 { get; set; }

        [JsonProperty("playerScore1")]
        public int PlayerScore1 { get; set; }

        [JsonProperty("playerScore2")]
        public int PlayerScore2 { get; set; }

        [JsonProperty("playerScore3")]
        public int PlayerScore3 { get; set; }

        [JsonProperty("playerScore4")]
        public int PlayerScore4 { get; set; }

        [JsonProperty("playerScore5")]
        public int PlayerScore5 { get; set; }

        [JsonProperty("playerScore6")]
        public int PlayerScore6 { get; set; }

        [JsonProperty("playerScore7")]
        public int PlayerScore7 { get; set; }

        [JsonProperty("playerScore8")]
        public int PlayerScore8 { get; set; }

        [JsonProperty("playerScore9")]
        public int PlayerScore9 { get; set; }

        public ParticipantStats()
        {

        }
    }
}
