namespace Week2Assignment2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            Console.WriteLine("Part 1");
            int n;
            int sum = 0;

            Console.Write("Input the number of elements to be stored in the array:");
            n = Convert.ToInt32(Console.ReadLine());

            int[] sumArr = new int[n];

            Console.WriteLine("Input " + n + " elements in the array :");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element [{i}]: ");
                sumArr[i] = Convert.ToInt32(Console.ReadLine());
                sum += sumArr[i];
            }

            Console.WriteLine($"Sum of all elements stored in the array is:  {sum}");
            #endregion

            #region Part 2
            Console.WriteLine("\nPart 2");

            int num1, num2, num3;

            Console.Write("Input 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 3rd number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }

            #endregion        

            Console.WriteLine("\nPart 3");

            int x, y;

            Console.Write("Input the value for X coordinate :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value for Y coordinate :");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the Origin.");
            }
            else if (x == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
            }
        }
    }
}
