namespace program5
{
    abstract class Abstraction
    {
        public Abstraction()  //Constructor
         {
            System.Console.WriteLine("Representing the Area of each Shape ");
         }

         public void Display()      //Non-Abstract method
         {
            System.Console.WriteLine("This is a non- abstract methods");
         }

        public abstract  void Area();  //Abstract method
    }

    class Square: Abstraction
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }
        public override void  Area()    //overriding the abstract method and implementing it
        {
            int ans = side*side;
            System.Console.WriteLine("The area of square:{0} " , ans);
        }
    }

    class rectangle :Abstraction
    {
        int length=0, breadth=0;
        public rectangle(int len, int br)
        {
            length = len;
            breadth = br;

        }
        public override void Area()
        {
            int ans = length*breadth;
            System.Console.WriteLine("The area of rectangle:{0}", ans);
        }
    }
}