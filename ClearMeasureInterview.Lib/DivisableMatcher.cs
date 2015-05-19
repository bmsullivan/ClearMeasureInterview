namespace ClearMeasureInterview.Lib
{
    public class DivisableMatcher
    {
        private readonly int _divisor;
        private readonly string _message;

        public string Message
        {
            get { return _message; }
        }

        public DivisableMatcher(int divisor, string message)
        {
            _divisor = divisor;
            _message = message;
        }

        public bool Matches(int dividend)
        {
            return dividend%_divisor == 0;
        }
    }
}