using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class LastNameComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            // Better to use if else if else constructions to code readability
            return x == null || y == null
                ? 0
                : !string.Equals(y.LastName, x.LastName, StringComparison.OrdinalIgnoreCase)
                ? string.Compare(y.LastName, x.LastName, StringComparison.OrdinalIgnoreCase)
                : 0;
        }
    }
}
