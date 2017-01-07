using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace analog_input
{
    public class Program
    {
        public static void Main()
        {
            AnalogInput dial = new AnalogInput(Cpu.AnalogChannel.ANALOG_0);

            while (true)
            {
                Thread.Sleep(100);
                Debug.Print(dial.Read().ToString());
            };
        }
    }
}
