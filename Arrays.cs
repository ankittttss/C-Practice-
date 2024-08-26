namespace MyConsoleApp
{
    public class Arrays
    {
        public static void ArrayMain()
        {
            // Input for array size
            Console.WriteLine("Enter the Size of the Array:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Taking input for the array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Printing the array elements
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1}: {arr[i]}");
            }

            // Understanding For Each Loop

            string[] names = new string[5];
            names[0] = "Ankit";
            names[1] = "Saini";
            names[2] = "Pranjal";
            names[3] = "Keshav";

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            // MultiDimensional Array

            Console.WriteLine("Enter the Rows:");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Columns:");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col]; // Corrected multidimensional array declaration

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"Enter element for position [{i},{j}]:");
                    matrix[i, j] = int.Parse(Console.ReadLine()); // Fixed input and parsing
                }
            }

            // Displaying the matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); // New line after each row
            }

            // Uncomment the following block if you want to flatten the matrix and iterate over it
            /*
            foreach (int item in matrix)
            {
                Console.WriteLine(item);
            }
            */

            // Jagged Arrays - A jagged array is an array of arrays such that member arrays can be of different sizes.

            int[][] temporary = new int[3][];

            temporary[0] = new[] { 10, 20, 30, 40 };
            temporary[1] = new[] { 30, 40, 60, 70 };
            temporary[2] = new[] { 40, 60, 90, 90, 80 };

            // Note: We use Jagged Arrays so that we can deal with containers having dynamic sizes.

            // Displaying the jagged array
            for (int i = 0; i < temporary.Length; i++)
            {
                for (int j = 0; j < temporary[i].Length; j++)
                {
                    Console.Write(temporary[i][j] + " ");
                }
                Console.WriteLine(); // New line after each jagged array row
            }
        }
    }
}
