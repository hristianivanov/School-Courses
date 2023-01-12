namespace ReflectionDemos
{
    using System.Reflection;
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Person);
            FieldInfo[] fields = type.GetFields((BindingFlags)60);

            Object classInstance = Activator.CreateInstance(type, new object[] { "Dimitrichko",17 });

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"{field.Name} - {field.GetValue(classInstance)}");
            }

            foreach (FieldInfo field in fields)
            {
                if(field.IsPrivate)
                {
                    field.SetValue(classInstance, "newPrivate");
                }
                Console.WriteLine($"{field.Name} - {field.GetValue(classInstance)}");
            }
        }
    }
}