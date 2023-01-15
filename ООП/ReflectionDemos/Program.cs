namespace ReflectionDemos
{
    using System.Reflection;
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Mathematics);
            FieldInfo[] fields = type.GetFields((BindingFlags)60);

            // Object classInstance = Activator.CreateInstance(type, new object[] { "Dimitrichko",17 });

            //foreach (FieldInfo field in fields)
            //{
            //    Console.WriteLine($"{field.Name} - {field.GetValue(classInstance)}");
            //}

            //foreach (FieldInfo field in fields)
            //{
            //    if(field.IsPrivate)
            //    {
            //        field.SetValue(classInstance, "newPrivate");
            //    }
            //    Console.WriteLine($"{field.Name} - {field.GetValue(classInstance)}");
            //}



            var methods = type.GetMethods((BindingFlags)60);
            Object classInstance = Activator.CreateInstance(type);
            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            foreach (MethodInfo method in methods)
            {
                if (method.GetParameters().Length == 2)
                {
                    object magicValue = method.Invoke(classInstance, new object[] { 100, 1 });
                    Console.WriteLine(magicValue);
                }
                else if (method.GetParameters().Length == 3)
                {
                    object magicValue = method.Invoke(classInstance, new object[] { 100, });
                }
                Console.WriteLine();
            }
        }
    }
}