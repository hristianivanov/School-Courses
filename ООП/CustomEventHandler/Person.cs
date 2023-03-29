namespace CustomEventHandler;

public class Person
{
    public event EventHandler<PersonEventArgs> PersonCreated = null!;
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void OnPersonCreated()
    {
        PersonCreated?.Invoke(this, new PersonEventArgs(Name, Age));
    }
}
