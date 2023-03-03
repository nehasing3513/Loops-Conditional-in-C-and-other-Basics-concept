using System;
namespace  program5
{
    class NearestThousand
    {
    public void findNearestRoundoff()
    {
        System.Console.WriteLine("Input Num ");
        var input = Convert.ToInt32(Console.ReadLine());
         int M = input % 1000;
          if(M<500){
            System.Console.WriteLine("1000");
            }
            else if (M>=500){
             System.Console.WriteLine("2000");
        }
    }
 }
}