using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeagueMatchAppConsole
{
    class Program
    {
        // File path to LoL match history data in JSON format
        private static readonly string filePath = @"d:\projects\leaguematchapp\matches1.json";
        private static MatchList AllMatches;

        public static void Main(string[] args)
        {
            AllMatches = ParseJsonFile(filePath);
            Console.WriteLine("Welcome to the League of Legends Match Stats App. Press 'q' at any time to exit the app.\n" +
                "Please enter a number from 1-100 to view match information.");

            MatchSelection();
        }

        /// <summary>
        /// Get user input then call method to display selected match information.
        /// </summary>
        private static void MatchSelection()
        {
            string userIn = Console.ReadLine();
            if (userIn == "q") return;
                
            if(int.TryParse(userIn, out int input))
            {
                if(input >= 1 && input <= 100)
                { 
                    Console.WriteLine("Match " + input);
                    DisplayMatch(input - 1);
                    Console.WriteLine("Please enter another number from 1 - 100 to view another match.");
                    MatchSelection();
                }
                else
                {
                    Console.WriteLine("Number is outside valid range. Please enter a number from 1 - 100.");
                    MatchSelection();
                }
            }
            else
            {
                Console.WriteLine("Please enter a number from 1 - 100.");
                MatchSelection();
            }

        }

        /// <summary>
        /// Display the match information based on the selected int value.
        /// </summary>
        /// <param name="input">The selected match, signifies the index of the MatchList's Matches field</param>
        private static void DisplayMatch(int input)
        {
            Console.WriteLine(AllMatches.Matches[input].ToString());
        }

        /// <summary>
        /// Convert information from specified JSON formatted file to create a MatchList object that
        /// contains all the match data.
        /// </summary>
        /// <param name="filePath">The path to the JSON file</param>
        /// <returns>The MatchList object</returns>
        private static MatchList ParseJsonFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<MatchList>(jsonString);
        }
    }
}
