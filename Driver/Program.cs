using System;
using WPICore;
using System.Threading;
namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	    Console.WriteLine(Core.WiringPiSetup().ToString());
	    Core.PinMode(27,PinMode.INPUT); 
	    Core.PullUpDownControl(27, PullUpDown.PUD_UP);
	    //Core.DigitalWrite(8, PinState.HIGH);
	    while(true){
		    Console.WriteLine(Core.DigitalRead(27));
		    Thread.Sleep(25);
	    }
        }
    }
}
