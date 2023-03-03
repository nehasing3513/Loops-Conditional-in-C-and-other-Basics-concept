
namespace program7
{
    class Matrix
    {
        public void createDisplay2D()
        {
            System.Console.WriteLine("Enter the no. of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the no. of columns:");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, col];
            System.Console.WriteLine("Enter your array elements");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            System.Console.WriteLine("Displaying your array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    System.Console.Write(arr[i, j] + " ");
                }
                System.Console.WriteLine("");
            }
        }

        public void createDisplayJaggedArray()
        {
            System.Console.WriteLine("Jagged Array:-");
            int[][] jaggedArray = //new int [5][]

              {
              new int[] { 3, 5, 7, },
              new int[] { 1, 0, 2, 4, 6 },
              new int[] {1, 2, 3, 4, 5, 6, 7, 8},
              new int[] {4, 5, 6, 7, 8}
              };

              System.Console.WriteLine("Displaying jagged Array:-");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + " ");
                }

                System.Console.WriteLine(" ");
            }
        }


    }
}