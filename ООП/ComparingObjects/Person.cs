namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Town { get; private set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            if (Name != other.Name)
                return Name.CompareTo(other.Name);
            if (Age != other.Age)
                return Age.CompareTo(other.Age);
            return Town.CompareTo(other.Town);
        }
    }
}