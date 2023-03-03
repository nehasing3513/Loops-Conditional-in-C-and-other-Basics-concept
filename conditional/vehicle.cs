namespace program5
{
    //implementing interfaces
     interface vehicle
     {
        void changeGear(int a);
        void speedUP(int a);
        void applybrakes(int a);
    }

    class Bicycle: vehicle
    {
        int speed;
        int gear;

        public void changeGear(int newgear)
        {
            gear = newgear;
        }
        public void speedUP(int increamentedspeed)
        {
            speed = speed+increamentedspeed;
        }
        public void applybrakes(int decrementedspeed)
        {
            speed = speed-decrementedspeed;
        }

       public void printStates()
       {
        Console.WriteLine("speed: " + speed + " gear: " + gear);
      }
    }
    
}