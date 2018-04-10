using System;
using System.Collections.Generic;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Please type Start to start the " +
            "timer.");
        string input = Console.ReadLine().ToLower();
        if (input == "start")
        {




        }
        Console.WriteLine("Please type Stop to stop the" +
            " timer");
        Console.ReadLine();


    }

    public class Timer
    {

        //Fields
        private decimal _startTime;
        private decimal _endTime;

        //Properties
        public decimal StartTime { get; set; }
        public decimal StopTime { get; set; }

        //Methods
        public void Start()
        {


        }

        public void Stop()
        {



        }


    }

}
