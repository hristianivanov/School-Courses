namespace CustomEventHandler;

public class Statistic
{
    public event EventHandler<MyEventArgs> Calculating = null!;
    public event EventHandler<NumberCheckedEventArgs> NumberChecking = null!;
    private int number;

    public Statistic()
    {

    }
    public Statistic(int number)
    {
        this.Number = number;
    }
    public int Number
    {
        get => number;
        set
        {
            NumberChecking.Invoke(this, new NumberCheckedEventArgs(value));
        }
    }
    public void Calculate(int[] nums)
    {
        int min = nums.Min();
        int max = nums.Max();
        double average = nums.Average();
        int sum = nums.Sum();
        Calculating!.Invoke(this, new MyEventArgs(min, max, average, sum));
    }
}
