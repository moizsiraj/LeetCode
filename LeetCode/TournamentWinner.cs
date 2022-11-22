using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TournamentWinners
    {
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var dictionary = new Dictionary<string, int>();
            var maxScore = 0;
            var team = string.Empty;
            for (int i = 0; i < results.Count; i++)
            {
                var home = competitions[i][0];
                var away = competitions[i][1];
                var result = results[i];

                if (!dictionary.ContainsKey(home))
                    dictionary.Add(home, 0);

                if (!dictionary.ContainsKey(away))
                    dictionary.Add(away, 0);

                if (result == 0)
                {
                    dictionary[away]++;
                    if (dictionary[away] > maxScore)
                    {
                        maxScore = dictionary[away];
                        team = away;
                    }

                }
                else
                {
                    dictionary[home]++;
                    if (dictionary[home] > maxScore)
                    {
                        maxScore = dictionary[home];
                        team = home;
                    }
                }
            }

            return team;
        }
    }
}
