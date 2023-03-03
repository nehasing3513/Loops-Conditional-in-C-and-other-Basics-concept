//using System;
namespace program5
{
    class Strings{
        public  void Display()
        {
             string s1 = "Hello";
             Console.WriteLine(s1);
        }

        public void stringMethods()
        {
            //clone
            String s1 = "Hello world";
            String s2 = (String)s1.Clone();
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);

            //compare - returns 0 and 1
            string s3 = "assignment";
            string s4 = "Assignment";
            System.Console.WriteLine(String.Compare(s3,s4));

            //Trim- Remove blank spaces from front and from the end of the string.
            String strs = "   Hello computer  ";
            System.Console.WriteLine("String after using Trim(): {0}",strs.Trim());
            System.Console.WriteLine("String in Uppercase:{0}",strs.ToUpper());
            System.Console.WriteLine("String in Lowercase: {0}",strs.ToLower());
        

            //index
            System.Console.WriteLine("Finding the index:{0}",strs);
            System.Console.WriteLine("Enter your string: ");
            String str = Console.ReadLine()!;
            System.Console.WriteLine("Here is your string:" + str);

            //splitting
            System.Console.WriteLine("Displaying string after splitting it: ");
            string oldstring = "Hello computers";
            string[] newstring = oldstring.Split(' ');
            foreach(string i in newstring)
                 System.Console.WriteLine(i);

            //replace
            string res = oldstring.Replace("Hello","I am a");
            System.Console.WriteLine("Replacing :{0} ",res) ;

            //isnullorwhitespace- checks whether the string is null or contains white-space characters
            
            
            System.Console.WriteLine("Enter your string: ");
            string str5 = Console.ReadLine()!;
            if(String.IsNullOrWhiteSpace(str5))
               System.Console.WriteLine("Invalid");
            
            
                   
        }
        

    }
}