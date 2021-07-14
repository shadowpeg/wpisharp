using System;
using Core;

namespace WPISPI
{
    public class SPI
    {
	    private readonly int channel;
	    private readonly int speed;

	    public SPI(int channel, int speed){
		    this.channel = channel;
		    this.speed = speed;
		    if(speed < 500000){
			    throw new Exception("Speed should be greater than 500 KHz (500,000 Hz)");
		    }
		    Core.WiringPiSPISetup(channel, speed);
	    }

	    public byte[] SPIRxTx(byte[] inData, int length){
		    byte[] trx = inData;
		    Core.SPIRxTx(ref trx);
		    return trx;
	    }

	    public byte[] SPIRxTx(byte[] inData){
		    return SPIRxTx(inData, inData.Length);
	    }
    }
}
