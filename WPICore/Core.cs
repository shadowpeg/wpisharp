using System;
using System.Runtime.InteropServices;

namespace WPICore
{
    public class Core
    {

	    [DllImport("wiringPi")]
	    private static extern int wiringPiSetup();
	    [DllImport("wiringPi")]
	    private static extern int wiringPiSetupGpio();
	    [DllImport("wiringPi")]
	    private static extern int wiringPiSetupPhys();
	    [DllImport("wiringPi")]
	    private static extern int wiringPiSetupSys();

	    [DllImport("wiringPi")]
	    private static extern void pinMode(int pin, int mode);
	    [DllImport("wiringPi")]
	    private static extern void pullUpDnControl(int pin, int pud);
	    [DllImport("wiringPi")]
	    private static extern void digitalWrite(int pin, int value);
	    [DllImport("wiringPi")]
	    private static extern void pwmWrite(int pin, int value);
	    [DllImport("wiringPi")]
	    private static extern int digitalRead(int pin);
	    [DllImport("wiringPi")]
	    private static extern int analogRead(int pin);
	    [DllImport("wiringPi")]
	    private static extern void analogWrite(int pin, int value);

	    [DllImport("wiringPi")]
	    private static extern int wiringPiSPISetup(int channel, int speed);
	    [DllImport("wiringPi")]
	    private static extern int wiringPiSPIDataRW(int channel, byte[] data, int len);

	    private Core(){
	    }



	    private static bool wpiInited = false;

#region Initializing Functions

	    public static int WiringPiSetup(){
		    wpiInited = true;
		    return wiringPiSetup();
	    }

	    public static int WiringPiSetupGpio(){
		    wpiInited = true;
		    return wiringPiSetupGpio();
	    }

	    public static int WiringPiSetupPhys(){
		    wpiInited = true;
		    return wiringPiSetupPhys();
	    }

	    public static int WiringPiSetupSys(){
		    wpiInited = true;
		    return wiringPiSetupSys();
	    }

#endregion

#region Pin Controlling Functions

	    public static void PinMode(int pin, PinMode mode){
		    CheckWPIInited();
		    pinMode(pin, (int)mode);
	    }

	    public static void PullUpDownControl(int pin, PullUpDown pupdnctrl){
		    CheckWPIInited();
		    pullUpDnControl(pin, (int)pupdnctrl);

	    }

	    public static void DigitalWrite(int pin, PinState state){
		    CheckWPIInited();
		    digitalWrite(pin, (int)state);
	    }

	    public static void PwmWrite(int pin, int val){
		    CheckWPIInited();
		    pwmWrite(pin, val);
	    }

	    public static int DigitalRead(int pin){
		    CheckWPIInited();
		    return digitalRead(pin);
	    }

	    public static int AnalogRead(int pin){
		    CheckWPIInited();
		    return analogRead(pin);
	    }

	    public static void AnalogWrite(int pin, int val){
		    CheckWPIInited();
		    analogWrite(pin, val);
	    }

	    


#endregion

#region SPI Related Function
	    public static int WiringPiSPISetup(int channel, int speed){
		    CheckWPIInited();
		    return wiringPiSPISetup(channel, speed);
	    }

	    public static int SPIRxTx(int channel, byte[] data, int len){
		    return wiringPiSPIDataRW(channel, data, len);
	    }
#endregion

	    private static void CheckWPIInited(){
		    if(!wpiInited){
			    throw new Exception("Wiring PI is not initialized");
		    }
	    }

    }
}
