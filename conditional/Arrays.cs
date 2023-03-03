using System;
namespace program4
{
    class Arrays
    {
        //creation and Displaying
        public int[] createDisplay()
        {
            int[] arr = new int[5];
            System.Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var i in arr)
                Console.WriteLine(i);

                return arr ;

        }

        //Deletion
        public void delete()
        {
            int[] arr = new int[6] { 10, 20, 30, 40, 50, 60 };
            int len = arr.Length;
            System.Console.WriteLine("Array elements are:");
            foreach (var i in arr)
                System.Console.WriteLine(i);

            System.Console.WriteLine("Enter the element to delete:");
            int num = Convert.ToInt32(Console.ReadLine());

            if ((arr.Contains(num)) == true)
            {
                int index = Array.IndexOf(arr, num);
                System.Console.WriteLine("index of num:" + index);
                for (int i = index; i < len - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                
                System.Console.WriteLine("Displaying the array after Deletion:-");
                for(int i=0;i<arr.Length-1;i++)
                    System.Console.WriteLine(arr[i]);
            }

            else
            {
                System.Console.WriteLine("Invalid Input");
            }
        }

        
        
        
    }
}