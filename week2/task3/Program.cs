﻿var time = new JupiterTime(2, 20);
var timeIn1Hours = time.AddHours(1);

PrintTime(timeIn1Hours);

void PrintTime(JupiterTime time)
{
    if (time.Minutes < 10) Console.WriteLine($"{time.Hours}:0{time.Minutes}");
    else Console.WriteLine($"{time.Hours}:{time.Minutes}");
}
class JupiterTime
{
    private int _hours = 0, _minutes = 0;
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0) throw new Exception("negative number not acceptable");
            else if (value > 9) _hours = (value % 10);
            else _hours = value;
        }
    }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value < 0) throw new Exception("time should be positive number");
            else if (value > 60)
            {
                _hours = _hours + (value / 60);
                if (_hours > 9) _hours = _hours - 10;
                _minutes = (value % 60);
            }
            else _minutes = value;
        }
    }

    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

     public JupiterTime AddHours(int number)
    {
        Hours = _hours + number;
        return new JupiterTime(_hours, _minutes);
    }
}