namespace CustomEventHandler;

public class PersonEventArgs : EventArgs
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonEventArgs(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}
