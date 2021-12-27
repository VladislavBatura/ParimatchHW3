using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class PlayerRankComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            return x == null || y == null ? 0 : y.Rank.CompareTo(x.Rank) != 0 ? y.Rank.CompareTo(x.Rank) : 0;
        }
    }
}
