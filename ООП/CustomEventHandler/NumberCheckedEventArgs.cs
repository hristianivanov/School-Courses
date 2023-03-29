namespace CustomEventHandler
{
    public class NumberCheckedEventArgs : EventArgs
    {
        public int Number { get; private set; }

        public NumberCheckedEventArgs(int number)
        {
            Number = number;
        }
    }
}
