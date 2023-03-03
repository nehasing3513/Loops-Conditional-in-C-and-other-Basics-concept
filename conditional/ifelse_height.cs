namespace program5
{
    class ifelse_height
    {
        public void findheight()
        {
            System.Console.WriteLine("Enter your height in inches: ");
            int height = Convert.ToInt32(Console.ReadLine());
            double fheight = height*2.54;

            if(fheight < 150)
              System.Console.WriteLine("Dwarf");

            else if(fheight >= 150 && fheight < 165)
               System.Console.WriteLine("Average Height");

            else if(fheight>= 165 && fheight < 195)
               System.Console.WriteLine("Tall");

            else if(fheight>=195)
              System.Console.WriteLine("Abnormal height");

              

        }
    }
}