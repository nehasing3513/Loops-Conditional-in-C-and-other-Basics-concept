using System;
namespace program1
{
    class jump
    {
        public void breakexample()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public void continueexample()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public void gotoexample()
        {
         
        int num = Convert.ToInt32(Console.ReadLine());  

        if(num >= 10) {
        
          goto repeat;
        }
          repeat: {
        Console.WriteLine("Enter a number less than 10");
          }
        Console.WriteLine(num + " is less than 10");
        Console.ReadLine();

            
        }
    }
}

