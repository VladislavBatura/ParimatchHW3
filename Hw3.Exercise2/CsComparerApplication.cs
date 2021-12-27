using Hw3.Exercise2.Comparers;
using Hw3.Exercise2.Models;

namespace Hw3.Exercise2
{
    public sealed class CsComparerApplication
    {
        /// <summary>
        /// CsCompare application return codes.
        /// </summary>
        public enum ReturnCode
        {
            Success = 0,
            InvalidArgs = -1
        }

        public ReturnCode Run(string[] args)
        {
            // TODO: Parse and validate the arguments and return result of the command.
            if (args is null || args.Length is 0)
            {
                return ReturnCode.InvalidArgs;
            }

            var stringLine = args.Select(x => x.Trim());
            if (stringLine.Count() > 1)
            {
                return ReturnCode.InvalidArgs;
            }
            var arg = stringLine.FirstOrDefault(x => x.Equals("age", StringComparison.Ordinal)
                || x.Equals("lastname", StringComparison.Ordinal)
                || x.Equals("rank", StringComparison.Ordinal));

            if (arg is null)
            {
                return ReturnCode.InvalidArgs;
            }

            IComparer<PlayerInfo> comparer;

            switch (arg)
            {
                case "age":
                    comparer = new AgeComparer();
                    break;
                case "lastname":
                    comparer = new LastNameComparer();
                    break;
                case "rank":
                    comparer = new PlayerRankComparer();
                    break;
                default:
                    return ReturnCode.InvalidArgs;
            }

            var players = CsComparerService.Compare(comparer);
            Console.WriteLine(string.Join("\n", players));

            return ReturnCode.Success;
        }
    }
}
