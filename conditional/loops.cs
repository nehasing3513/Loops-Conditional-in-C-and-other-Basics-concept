using System;
namespace program2
{
    class loops
    {
        public void forlooping()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void foreachloop()
        {
            var num = new int[6];
            Console.WriteLine("Enter the array elements:-");
            for (int i = 0; i < num.Length; i++)
            {
                i=i+1;
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Displaying the array elements: ");
            foreach (var j in num){
                Console.WriteLine(j);
                 //j=j+1;
            }

            int len = num.Length;
            Console.WriteLine(len);
        }
    }
}
