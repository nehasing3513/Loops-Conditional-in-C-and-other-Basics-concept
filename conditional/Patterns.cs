namespace program5
{
    class Patterns
    {
        public void printingPatterns()
        {
            for(int i= 1; i<=3; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    if(j==5 || j== 6)
                      continue;

                    System.Console.Write(j+" ");
                   
                }
                System.Console.WriteLine();
            }
             
             
           System.Console.WriteLine("Printing 2nd pattern");
            for(int i= 1; i<=3; i++)
            {
                for(int j= 10; j<=1; j--)
                {
                    if(i==3)
                    {
                        if(j==2 || j==1)
                           continue;
                    }
                    System.Console.WriteLine(j +" ");
                }

                System.Console.WriteLine();
            }

        }
    }
}