//A employee is resigning from organisation ,you need to notify this to each department, so that they can discard all his details from their respective departments,so that they can take their further actions..
using System;
namespace program1
{
    public delegate void EmployeeSeparatedEventHandler();
    class EventsDemo
    {
        //1.Declare a delegate. Establishing a connect between publisher and subscriber. Its act a eventHandler
 
        public event EmployeeSeparatedEventHandler Employeeseparated; //2.Define the event based on delegate.
        public void separate()
        {

            if(Employeeseparated != null)  //If this event is not subscribed by anyonr this always be null.
              Employeeseparated.Invoke(); //Invoking a event
        }

        //Creating a subscriber(Finance class)which need to be notify when a employee resigns.
        class Finance  //This class should have the reference of EventsDemo class.
        {
            private EventsDemo emp;
            public  Finance(EventsDemo emp)
            {
                this.emp = emp;
                emp.Employeeseparated+=EmployeeSeparatedEventHandler;
                
                 //publisherclass.eventname+= eventhandler
            }

             public  void EmployeeSeparatedEventHandler() //EventHandler,(should have the same function signature as of delegate).  a method that contains the code that gets executed in response to a specific event that occurs in an application.
             {
                System.Console.WriteLine("Finance Department: employee separation process related  to finance.");
                 
             }

        }
    }
}
