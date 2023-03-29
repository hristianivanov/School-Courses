namespace Events
{
    public class PasswordChecker
    {
        public event EventHandler<PasswordEventArgs> PasswordChecked;

        public void CheckPassword(string password)
        {
            bool isValid = false;

            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower))
                isValid = true;

            OnPasswordChecked(new PasswordEventArgs(isValid));
        }

        private void OnPasswordChecked(PasswordEventArgs e)
        {
            PasswordChecked?.Invoke(this, e);
        }
    }
}
