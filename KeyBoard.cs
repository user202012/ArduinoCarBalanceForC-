using System;


public class KeyBoard
{
    public IBalanceCar balanceCar;
    //public bool trigger = true;
    public KeyBoard(IBalanceCar IbalanceCar)
    {
        balanceCar = IbalanceCar;
    }

    public string Run()
	{
        string getString = "";
        switch (Convert.ToInt32(Console.ReadKey().KeyChar))
        {
            case 119:
                Console.WriteLine("Forward");
                getString = balanceCar.Forward();
                break;
            case 115:
                Console.WriteLine("Retreat");
                getString = balanceCar.Retreat();
                break;
            case 97:
                Console.WriteLine("Left");
                getString = balanceCar.Left();
                break;
            case 100:
                Console.WriteLine("Right");
                getString =balanceCar.Right();
                break;
            //case 7:
            //   Console.WriteLine("Exit");
            //    trigger = false;
            //    break;
            case 32:
                Console.WriteLine("Stop");
                getString = balanceCar.Stop();
                break;
        }
        return getString;
	}
}
