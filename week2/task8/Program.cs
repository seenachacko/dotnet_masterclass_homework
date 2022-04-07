var time1 = new TitanTime(1000, 40);
var time2 = new TitanTime(11, 7);
var time3 = new TitanTime(31,70);
var time4 = new TitanTime(9, 11);
var time5 = new TitanTime(0, 0);

Console.WriteLine(time1.ToString());
Console.WriteLine(time2.ToString());
Console.WriteLine(time3.ToString());
Console.WriteLine(time4.ToString());
Console.WriteLine(time5.ToString());


class TitanTime
{

    public int Hour;
    public int Minutes;
    public TitanTime(int hour, int minutes)
    {
    if (hour < 0 || minutes < 0) throw new Exception("should be grater than 0");
    Hour = hour % 900;
    if (minutes > 60)
    {
    Minutes = minutes % 60;
    Hour += minutes / 60;
    }

    }
    public override string ToString()
    {
        return $"{Hour:000}:{Minutes:00}";
    }
}