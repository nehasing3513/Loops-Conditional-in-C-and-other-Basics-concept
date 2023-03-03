using System;
//Delegates- is a type function pointer , and holds the reference of a method and then calls the method for execution.
//
namespace program5
{
    // Step1: Declaring Delegates
    public delegate void AddsumDelegate(int a, int b);  
     public delegate String gettingmessageDelegate(String name);
     public delegate void rectDelegates(double length, double width);
     public delegate string  GreetingsDelegates(String name);
     

    class MyDelegate
    {
        public void Addsum(int a, int b)
        {
            int sum = 0;
            sum = a+b;
            System.Console.WriteLine(sum);
        }

        public static String gettingmessage(String name)
        {
            return "Hello "+ name;
        }

    }

    //multicast Delegates - if in a class , there are two methods with same return type and parameter,i.e same signature , we can call them by using same delegates.
    class Rectangle
    {
        public void Area(double length, double width)
        {
            double ans = 0.0;
            ans = length*width;
            System.Console.WriteLine("The Area of rectangle: " + ans);

        }

        public void Perimeter(double len, double width)
        {
            double ans = 0.0;
            ans = 2*(len+width);
            System.Console.WriteLine("The perimeter of rectangle: " +ans);
        }
    }

    //Anonymous methods - says that instead of binding the methods to delegates, we can directly bind a codeblock to delegates.

    class mygreetings
    {
        public string  Greetings(String name)
        {
             return "Good Morning " + name;
        }
    }

    //when to use multicast-
    /*
       1. When there is a class, which contains methos with same signature and all those methods work on a same value.
       2. All the methods should be void, becoz if not so, then it will store the value of the last called method,because value of the current returning function will be replaced by the value return by the later function. i.e it will override the values. 
    */
    
    //Advantage of Anonymous method
    /* 1. Lesser typing work. */
}