using System;
using System.IO.Ports;
using System.Threading;

public class Bluetooth
{

    public static SerialPort _serialPort;
    public string content;

    public void Push(string test)
    {
        _serialPort.WriteLine(test);
    }

    public void Initialize()
    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "COM4";
        _serialPort.BaudRate = 38400;
        _serialPort.Parity = Parity.None;
        _serialPort.DataBits = 8;
        _serialPort.StopBits = StopBits.One;
    }

    public void OpenConnection()
    {
        _serialPort.Open();
        _serialPort.ReadTimeout = 1000;
        Console.WriteLine("Port Opened!");
    }

    public void CloseConnection()
    {
        _serialPort.Close();
    }

}
