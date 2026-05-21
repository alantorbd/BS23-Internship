using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class AsynchornusProgramming
    {
        public AsynchornusProgramming()
        {
            
            
        }

        public async Task StartFan()
        {
            Console.WriteLine("Goto the shop.");
            var fixMonitorTask = FixMonitorAsync();
            BuildFanCircuit();
            await fixMonitorTask;
            Console.WriteLine("All Work is Finish.");
        }

        async Task FixMonitorAsync()
        {
            Console.WriteLine("Start fixing monitor..");
            await Task.Delay(2000);
            Console.WriteLine("Finish fixing monitor");
        }

        void BuildFanCircuit()
        {
            Console.WriteLine("Start makeing circuit...");
            Console.WriteLine("Finish makeing Cirucit.");
        }
    }


 

class NewTask
    {
        static async Task Main()
        {
            // 1. Created the remote control (CancellationTokenSource)
            CancellationTokenSource cts = new CancellationTokenSource();

            Console.WriteLine("1. User request received...");

            // 2. We are passing two things here: 
            // The first is our value ("Spider-Man.mp4"), and the second is the token.
            Task downloadTask = DownloadMovieAsync("Spider-Man.mp4", cts.Token);

            // 3. Canceling after 2 seconds
            await Task.Delay(2000);
            Console.WriteLine("3. User: Clicked the Cancel button!");
            cts.Cancel();

            try
            {
                await downloadTask;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("6. System: The movie download has been canceled.");
            }
        }

        // Background method: Takes the movie name (string) first, and the token at the end
        static async Task DownloadMovieAsync(string movieName, CancellationToken token)
        {
            Console.WriteLine($"2. Server: Searching and starting download for movie '{movieName}'...");

            for (int i = 1; i <= 5; i++)
            {
                // Checking if cancellation was requested
                token.ThrowIfCancellationRequested();

                // The value we sent (movieName) will be printed here
                Console.WriteLine($"-> Downloading '{movieName}'... {i * 20}%");

                await Task.Delay(1000, token);
            }
            Console.WriteLine($"5. '{movieName}' download 100% complete!");
        }
    }


}
