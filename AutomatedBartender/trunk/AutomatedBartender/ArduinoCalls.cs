﻿using System;
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

        public void TurnOnMotor(int port)
        {
            if (port == 1)
                TurnOnMotor(1);
            else if (port == 2)
                TurnOnMotor2();
            else if (port == 3)
                TurnOnMotor3();
            else if (port == 4)
                TurnOnMotor4();
            else if (port == 5)
                TurnOnMotor5();
            else if (port == 6)
                TurnOnMotor6();
        }

        public void TurnOffMotor(int port)
        {
            if (port == 1)
                TurnOffMotor(1);
            else if (port == 2)
                TurnOffMotor2();
            else if (port == 3)
                TurnOffMotor3();
            else if (port == 4)
                TurnOffMotor4();
            else if (port == 5)
                TurnOffMotor5();
            else if (port == 6)
                TurnOffMotor6();
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

        public void TurnOnMotor5()
        {
            ArduinoPort1.Write("i");
        }

        public void TurnOffMotor5()
        {
            ArduinoPort1.Write("j");
        }

        public void TurnOnMotor6()
        {
            ArduinoPort1.Write("k");
        }

        public void TurnOffMotor6()
        {
            ArduinoPort1.Write("l");
        }


    }
}
