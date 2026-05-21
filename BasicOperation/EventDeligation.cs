using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class EventDeligation
    {
        public delegate void SwitchOnDelegate();
        public event SwitchOnDelegate SwitchOnEvent;
        public EventDeligation()
        {
            //SwitchOnEvent += Fan;
            //if(SwitchOnEvent != null)
            //{
            //    SwitchOnEvent();
            //}
            //else
            //{
            //    Console.WriteLine("Error in Switch");
            //}

            //SwitchOnDelegate switchOnDelegate = Fan;
            //switchOnDelegate?.Invoke();

            Action<int,int,int> onFan = Fan;
            
            onFan(35,6,46);

            Func<int> onLigth = Light;
            onLigth += Tv;
            Console.WriteLine($"Deligait Call: {onLigth()}");

            Predicate<int> isEven = IsEven;

        }

        public void Fan(int a, int b, int c)
        {
            Console.WriteLine($"Fan is on {a} {b} {c}");
        }
        public int Light()
        {
            Console.WriteLine("Light is on");
            return 1;
        }

        public int Tv()
        {
            Console.WriteLine("Tv is on");
            return 4;
        }

        public bool IsEven(int number) {
            return number % 2 == 0;
        }

    }
}
