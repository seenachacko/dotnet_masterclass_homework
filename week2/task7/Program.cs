
var signaler = new Signaler();
signaler.AddTime(new JupiterTime(2, 00));
signaler.AddTime(new JupiterTime(4, 00));
signaler.AddTime(new JupiterTime(6, 00));
//signaler.Inform();

// We woke up at 4:21
signaler.Check(new JupiterTime(6, 21));

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
}

class Signaler
{
    List<JupiterTime> SinglerTimeList = new List<JupiterTime>();


    public void AddTime(JupiterTime time)

    {
        SinglerTimeList.Add(time);
    }


    public void Inform()
    {
        if (SinglerTimeList.Count == 0)
        {
            Console.WriteLine("No timers added yet");
        }
        else
        {
            foreach (var time in SinglerTimeList)
            {
                Console.WriteLine($"({time.Hours}:{time.Minutes})");
            }
        }
    }
    public void Check(JupiterTime time)
    {
        bool timerFound = false;
        foreach (var item in SinglerTimeList)
        {
            if (time.Hours > item.Hours || (time.Hours == item.Hours && time.Minutes > item.Minutes))
            {
                Console.WriteLine($"{item.Hours}:{item.Minutes}");
                timerFound = true;
            }
        }
        if (!timerFound) Console.WriteLine("No signals needed to be sent yet.");

    }



}
