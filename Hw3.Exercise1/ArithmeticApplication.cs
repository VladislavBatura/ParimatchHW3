using System.Globalization;

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
            if (args is null || args.Length == 0)
            {
                return ReturnCode.InvalidArgs;
            }
            var lineArray = args.Select(x => x.Trim());
            var stringArray = lineArray.Where(x =>
                int.TryParse(x, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result));

            // it can be possible enumeration here
            if (stringArray.Count() != lineArray.Count())
            {
                return ReturnCode.InvalidArgs;
            }

            var numberList = new List<int>();

            /* Not necessary to check for a int.MaxValue here. For example:
             int.MaxValue = 2147483647
             if I pass the 2147483646 = it's not a max value of integer, but it should be also throw an exception
             
             You should use checked{ YOUR_LOGIC_HERE } construction in ArithmeticProcessor.Calculate method to handle all invalid cases and throw an exception
             */
            try
            {
                numberList = stringArray.Select(x =>
                    int.Parse(x, NumberStyles.Integer, CultureInfo.InvariantCulture)).ToList();
                if (numberList.Contains(int.MaxValue))
                {
                    return ReturnCode.Exception;
                }
            }
            catch
            {
                return ReturnCode.Exception;
            }

            var result = ArithmeticProcessor.Calculate(numberList);
            Console.WriteLine(string.Join(" ", result));

            return ReturnCode.Success;
        }
    }
}
