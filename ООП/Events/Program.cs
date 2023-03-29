namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            PasswordChecker passwordChecker = new PasswordChecker();
            passwordChecker.PasswordChecked += PasswordChecker_PasswordChecked;

            passwordChecker.CheckPassword("MyPassword123");
            passwordChecker.CheckPassword("short");
        }
        private static void PasswordChecker_PasswordChecked(object sender, PasswordEventArgs e)
        {
            if (e.IsValid)
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is not valid");
        }
    }
}