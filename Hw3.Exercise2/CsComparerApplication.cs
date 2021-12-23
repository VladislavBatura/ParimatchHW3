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

            // IComparer<PlayerInfo> comparer = null;
            // var players = CsComparerService.Compare(comparer);
            // Console.WriteLine(string.Join("\n", players));

            return ReturnCode.Success;
        }
    }
}
