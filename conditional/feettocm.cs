using System;
namespace program5
{
    class feettocm
    {
        public void convrting_feetTocm()
        {
            System.Console.WriteLine("Enter your feet");
            int feet = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter inches: ");
            int inches = Convert.ToInt32(Console.ReadLine());

            double ans = ((feet*12)+inches)*2.54;
            System.Console.WriteLine(ans +"cm");
        }
    }
}