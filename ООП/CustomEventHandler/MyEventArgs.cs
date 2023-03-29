namespace CustomEventHandler;

public class MyEventArgs : EventArgs
{
    public int Min { get; set; }
    public int Max { get; set; }
    public double Average { get; set; }
    public int Sum { get; set; }
    public MyEventArgs(int min, int max, double average, int sum)
    {
        this.Min = min;
        this.Max = max;
        this.Average = average;
        this.Sum = sum;
    }
}
