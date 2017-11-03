using System;
using System.Diagnostics;

public class Program
{
	public static void Main()
	{
        Timer myTimer = new Timer();
        bool continueAsking = true;
        do
        {
            Console.WriteLine("What did you want to do?"); // "0" =start "1" =stop "x" =exit 

            var input = Console.ReadLine();

            if (input == "1")
            {
                myTimer.Stop();
                Console.WriteLine($"The time was {myTimer.StopWatch.Elapsed}");
            }

            if (input == "0")
            {

                try
                {
                    myTimer.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine( ex.Message);
                }


               
            }

            if (input == "x")
            {
                // end program
                continueAsking = false;
            }
        } while ( continueAsking);
	}
}

public class Timer
{
    // define properties
    public bool IsTimerWorking { get; set; }
    public Stopwatch StopWatch { get; set; }
    // define methods  

    public void Start()
    {
        if (IsTimerWorking)
        {
            throw new InvalidOperationException("Press 1 to stop the watch");
            
        }
        else

        {

            // reset timer 
            
            StopWatch = Stopwatch.StartNew();
            // kick off timer
            

            IsTimerWorking = true;
        }
    }

    public void Stop()
    {
        StopWatch.Stop();


        IsTimerWorking = false;
    }
}