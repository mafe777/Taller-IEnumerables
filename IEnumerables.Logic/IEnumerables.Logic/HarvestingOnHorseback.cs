using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables.Logic
{
    public class HarvestingOnHorseback
    {
        private Dictionary<string, string> field;
        private readonly int[] newPositionOfTheHorse;

        public HarvestingOnHorseback(string fruits, string PositionHorse)
        {
            field = new Dictionary<string, string>();
            string[] fruitsArray = fruits.Split(',');
            foreach (string fruit in fruitsArray)
            {
                field[fruit.Substring(0, 2)] = fruit.Substring(2);
            }
            newPositionOfTheHorse = new int[] { 8 - int.Parse(PositionHorse[1].ToString()), PositionHorse[0] - 'A' };
        }

        public string CollectedFruits(string movements)
        {
            string collectedFruits = string.Empty;
            foreach (string movement in movements.Split(','))
            {
                int[] newPosition = MoveTheHorse(movement);
                string newPositionStr = (char)('A' + newPosition[1]) + (8 - newPosition[0]).ToString();
                if (field.ContainsKey(newPositionStr))
                {
                    collectedFruits += field[newPositionStr];
                    field.Remove(newPositionStr);
                }
            }
            return collectedFruits;
        }

        private int[] MoveTheHorse(string movement)
        {
            int row = newPositionOfTheHorse[0];
            int column = newPositionOfTheHorse[1];
            switch (movement)
            {
                case "UL":
                    row -= 2;
                    column -= 1;
                    break;
                case "UR":
                    row -= 2;
                    column += 1;
                    break;
                case "LU":
                    row -= 1;
                    column -= 2;
                    break;
                case "LD":
                    row += 1;
                    column -= 2;
                    break;
                case "RU":
                    row -= 1;
                    column += 2;
                    break;
                case "RD":
                    row += 1;
                    column += 2;
                    break;
                case "DL":
                    row += 2;
                    column -= 1;
                    break;
                case "DR":
                    row += 2;
                    column += 1;
                    break;
                default:
                    throw new ArgumentException("Wrong Move");
            }
            if (column < 0 || column > 7 || row < 0 || row > 7)
            {
                throw new ArgumentException("Wrong Move");
            }
            newPositionOfTheHorse[0] = row;
            newPositionOfTheHorse[1] = column;
            return newPositionOfTheHorse;
        }
    }
}
