using System;

public class BalanceCar: IBalanceCar
{
    

	public string Forward()
	{
        return "$1,0,0,0,0,0,0,0,0,0#";
	}

    public string Retreat()
    {
        return "$2,0,0,0,0,0,0,0,0,0#";
    }

    public string Left()
    {
        return "$3,0,0,0,0,0,0,0,0,0#";
    }

    public string Right()
    {
        return "$4,0,0,0,0,0,0,0,0,0#";
    }

    public string Stop()
    {
        return "$0,0,0,0,0,0,0,0,0,0#";
    }

}
