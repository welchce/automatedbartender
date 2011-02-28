using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace AutomatedBartender
{
    class ArduinoCalls
    {
        SerialPort ArduinoPort1;
        public void StartArduinoCommunication()
        {
            ArduinoPort1 = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            ArduinoPort1.Open();
        }

        public void TurnOnMotor1()
        {
            ArduinoPort1.Write("a");
        }

        public void TurnOffMotor1()
        {
            ArduinoPort1.Write("b");
        }

        public void TurnOnMotor2()
        {
            ArduinoPort1.Write("c");
        }

        public void TurnOffMotor2()
        {
            ArduinoPort1.Write("d");
        }

        public void TurnOnMotor3()
        {
            ArduinoPort1.Write("e");
        }

        public void TurnOffMotor3()
        {
            ArduinoPort1.Write("f");
        }

        public void TurnOnMotor4()
        {
            ArduinoPort1.Write("g");
        }

        public void TurnOffMotor4()
        {
            ArduinoPort1.Write("h");
        }

    }
}
