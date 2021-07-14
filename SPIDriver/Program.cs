using System;
using WPICore;
using WPISPI;

namespace SPIDriver
{
    class Program
    {
        static void Main(string[] args)
        {
		Core.WiringPiSetup();
		var spi = new SPI(0, 500000);
        }
    }
}
