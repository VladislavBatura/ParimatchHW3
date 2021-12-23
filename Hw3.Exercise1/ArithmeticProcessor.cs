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

            throw new NotImplementedException("Should be implemented by executor");
        }
    }
}
