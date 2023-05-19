using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IEnumerables.Logic
{
    public class HorsesInConflict
    {
        private LinkedList<string> LocationOfTheHorses;
        private Dictionary<string, List<string>> HasConflictWith;

        public HorsesInConflict()
        {
            LocationOfTheHorses = new LinkedList<string>();
            HasConflictWith = new Dictionary<string, List<string>>();
        }

        public static void ValidatePositions(string locations)
        {
            string[] separatedLocations = locations.Split(',');
            foreach (string separatedLocation in separatedLocations)
            {
                if (!Regex.IsMatch(separatedLocation.Trim(), "^[A-H][1-8]$"))
                {
                    throw new Exception("Check Again.Invalid Location");
                }
            }
        }

        public void CheckEntry(string input)
        {
            string[] locations = input.Split(',');
            foreach (string location in locations)
            {
                LocationOfTheHorses.AddLast(location.Trim());
                HasConflictWith[location.Trim()] = new List<string>();
            }

            foreach (string location in LocationOfTheHorses)
            {
                ConflictWith(location);
            }
        }

        private void ConflictWith(string location)
        {
            foreach (string anothermovement in LocationOfTheHorses)
            {
                if (location != anothermovement && HaveDisagreement(location, anothermovement))
                {
                    if (!HasConflictWith[location].Contains(anothermovement))
                    {
                        HasConflictWith[location].Add(anothermovement);
                    }
                    if (!HasConflictWith[anothermovement].Contains(location))
                    {
                        HasConflictWith[anothermovement].Add(location);
                    }
                }
            }
        }

        private bool HaveDisagreement(string location1, string location2)
        {
            int x1 = location1[0] - 'A';
            int y1 = location1[1] - '1';
            int x2 = location2[0] - 'A';
            int y2 = location2[1] - '1';

            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);

            return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
        }


        public string Results()
        {
            var results = string.Empty;
            foreach (string location in LocationOfTheHorses)
            {
                results += $"Analyzing Horse In {location} => ";
                if (HasConflictWith[location].Count == 0)
                {
                    results += " ";
                }
                else
                {
                    for (int i = HasConflictWith[location].Count - 1; i >= 0; i--)
                    {
                        results += $"Conflict With {HasConflictWith[location][i]}   ";
                    }
                }
                results += "\n";
            }
            return results;
        }




    }
}
