namespace Events
{
    public class PasswordEventArgs : EventArgs
    {
        public bool IsValid { get; private set; }

        public PasswordEventArgs(bool isValid)
        {
            IsValid = isValid;
        }
    }
}
