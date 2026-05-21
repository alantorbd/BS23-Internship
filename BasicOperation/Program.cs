using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AsynchornusProgramming asynchornusProgramming = new AsynchornusProgramming();

            var fan = asynchornusProgramming.StartFan();
            await fan;


        }
    }
}
