using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class AgeComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            return x == null || y == null ? 0 : y.Age.CompareTo(x.Age) != 0 ? y.Age.CompareTo(x.Age) : 0;
        }
    }
}
