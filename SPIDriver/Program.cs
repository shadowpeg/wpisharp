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
		var testBytes = new byte[] {0xF4, 0xA0, 0x33};
		DumpHex(testBytes);
		var ret = spi.SPIRxTx(testBytes);
		DumpHex(ret);
        }


	private static void DumpHex(byte[] bytes){
		for(int i = 0; i < bytes.Length; i++){
			Console.Write($"{bytes[i].ToString("X2")} ");
		}
		Console.WriteLine();
	}
    }
}
