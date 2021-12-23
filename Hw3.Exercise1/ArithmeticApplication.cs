namespace Hw3.Exercise1
{
    public sealed class ArithmeticApplication
    {
        /// <summary>
        /// Arithmetic application return codes.
        /// </summary>
        public enum ReturnCode
        {
            Success = 0,
            InvalidArgs = -1,
            Exception = -2
        }

        public ReturnCode Run(string[] args)
        {
            // TODO: Parse and validate the arguments and convert it to the numbers.
            // var result = ArithmeticProcessor.Calculate();
            // Console.WriteLine(string.Join(" ", result));

            return ReturnCode.Success;
        }
    }
}