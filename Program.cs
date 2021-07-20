using System;

namespace Arduino
{
    class Program
    {
        static void Main(string[] args)
        {
            Bluetooth bluetooth = new Bluetooth();
            BalanceCar balanceCar = new BalanceCar();
            KeyBoard keyBoard = new KeyBoard(balanceCar);

            bluetooth.Initialize();
            bluetooth.OpenConnection();

            string status = "";
            while (status != "false")
            {
                //Console.WriteLine(Convert.ToInt32(Console.ReadKey().KeyChar));
                status = keyBoard.Run();
                bluetooth.Push(status);
            }

            bluetooth.CloseConnection();
        }
    }
}
