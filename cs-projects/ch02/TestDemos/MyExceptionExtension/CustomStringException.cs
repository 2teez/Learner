namespace CustomStringException
{
    public class StringLengthException : Exception
    {
        public StringLengthException(
            string title = "StringLengthException",
            string err = "Length of the string can't be 0 or 1.") : base(err)
        {
            Console.WriteLine(base.Message);
            Console.Write(title + " :");
            Console.WriteLine(err);
        }
    }
}
