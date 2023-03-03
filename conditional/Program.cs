// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using program1;
using program2;
using program3;
using program4;
using program5;
using program7;

 namespace csharp
 {
    class Program
     {
        static void Main(string[] args)
         {
            
            //jump statements
            /*
            jump obj = new jump();
            System.Console.WriteLine("Example of break:");
            obj.breakexample();
            System.Console.WriteLine("Example of continue:");
            obj.continueexample();
            System.Console.WriteLine("Example of gotoexample:");
            obj.gotoexample(); 
            */
           

           /*
            //loops 
            loops obj1 = new loops();
            System.Console.WriteLine("For looping:- ");
            obj1.forlooping();
            System.Console.WriteLine("Foreach looping:- ");
            obj1.foreachloop();

            //conditional
            SwitchExample obj2 = new SwitchExample();
            System.Console.WriteLine("switchstatement:- ");
            obj2.switchprogram();
            */
            

            //Arrays
           /* Arrays obj3 = new Arrays();
            obj3.delete(); */

            //String
            /*
            Strings obj4 = new Strings();
            obj4.Display();
            obj4.stringMethods();
            
            /*
            Matrix obj = new Matrix();
            obj.createDisplay2D();
            obj.createDisplayJaggedArray();*/

            //feettocm
            /*
            feettocm obj = new feettocm();
            obj.convrting_feetTocm();
            */

            //NearestThousand
            /*
            NearestThousand obj = new NearestThousand();
            obj.findNearestRoundoff();
            */

            //ifelse_height
            /*
            ifelse_height obj = new ifelse_height();
            obj.findheight();
            */

            //Pattern
            /*
            Patterns obj = new Patterns();
            obj.printingPatterns();
            */

            //Abstraction
            // Abstraction obj ;
            // obj = new Square(10);
            // obj.Display(); 
            // obj.Area();
            // rectangle obj1 = new rectangle(4,6);
            // obj1.Area();
            

            //Delegates
            /*
            //calling methods by creating objects
            /*
            Delegateess obj1 = new Delegateess();
            obj1.Addsum(10,20);
            String str = obj1.gettingmessage("computer");
            System.Console.WriteLine(str);
            */
            //calling methods by using delegates
            
        //     MyDelegate obj1 = new MyDelegate();
        //     AddsumDelegate obj2 = new AddsumDelegate(obj1.Addsum); //Step2      (here, as Addsum is a non-static method so, we are passing it by creating a objects as no-static methods cann't be call from a static class.)
        //     obj2(90,100); //Step3: invoking/calling the method.
        //    // obj2.Invoke(90,100);
        //     gettingmessageDelegate obj3 = new gettingmessageDelegate(MyDelegate.gettingmessage);
        //     System.Console.WriteLine(obj3("COMPUTER"));

            // //multicastDelegates
            // Rectangle rect = new Rectangle();
            // rectDelegates obj5 = new rectDelegates(rect.Area);
            // obj5+= rect.Perimeter; //binding method to delegates
            // obj5(30,40);

            // //Anonymous methods-
            // mygreetings greet = new mygreetings();
            // GreetingsDelegates obj = delegate(String name)    //here, the greetingdelegate already know the return type of greetings, and so its not giving any error
            // {
            //     return "Hello "+ name + "a very good morning";   //writing the logic
            // };
            // String str = obj.Invoke("Scottlin");
            // System.Console.WriteLine(str);

            //Partial class
            // Partialll p = new Partialll();
            // p.set(40);
            // p.Display();

            //mystatic
            //mystatic.staticmethoddisplay();

            //Interfaces: vehicle
            // Bicycle obj = new Bicycle();
            // obj.changeGear(20);
            // obj.speedUP(50);
            // obj.applybrakes(70);
            // obj.printStates();

            //EventDemo
            //how to invoke eventHandler
            EventsDemo obj = new EventsDemo();
            // obj.separate();  //now the event will not be in invoke as its not being subscribed.
            


            


        
        }
    }

}