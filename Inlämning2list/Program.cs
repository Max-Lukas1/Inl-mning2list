using System;
namespace inlämning2list
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 5, 8, 20, 15 };
            int maxNumber = Max(numbers);

            Console.WriteLine("Det största talet i listan är: " + maxNumber);
        }

        static int Max(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Listan får inte vara tom.");
            }

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }
    }

}

