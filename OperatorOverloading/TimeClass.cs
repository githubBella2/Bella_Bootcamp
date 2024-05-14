namespace OperatorOverloading;

public class TimeClass
{
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public TimeClass(int hours, int minute)
    {
        Hours = hours;
        Minutes = minute;
    }

    public static TimeClass operator -(TimeClass t1, TimeClass t2)
    {
        int jam = t1.Hours - t2.Hours;
        int menit = t1.Minutes - t2.Minutes;
       
        TimeClass time = new(jam, menit);
        return time;
    }
}
