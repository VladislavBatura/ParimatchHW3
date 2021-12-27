namespace Hw3.Exercise1
{
    public static class ArithmeticProcessor
    {
        /// <summary>
        /// Calculates numbers by algorithm.
        /// </summary>
        /// <param name="numbers">Collection of numbers.</param>
        /// <returns>
        /// Returns <c>IEnumerable</c> of sorted numbers. 
        /// </returns>
        /// <exception cref="ArgumentNullException">Sequence is null.</exception>

        public static IEnumerable<int> Calculate(List<int> numbers)
        {
            if (numbers is null)
                throw new ArgumentNullException(nameof(numbers));

            numbers = numbers.Select((x, i) =>
            {
                if (i % 2 is 0 || i is 0)
                {
                    return x * 2;
                }
                i++;
                return x - 10;
            }).ToList();

            return numbers.Distinct().OrderBy(x => x).ToList();
        }
    }
}
