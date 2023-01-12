namespace ReflectionDemos
{
    public class Person
    {
        private string privateField = "private";
        internal string internalField = "internal";
        static string staticField = "static";
        public string publicField = "public";

        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
