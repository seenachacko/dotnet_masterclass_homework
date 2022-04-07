
var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 40;

PrintTime(time);

void PrintTime(JupiterTime InputTime)
{
    Console.WriteLine($"{InputTime.Hours}:{InputTime.Minutes}");

}


public class JupiterTime
{

    public int Hours { get; set; }
    public int Minutes { get; set; }

}