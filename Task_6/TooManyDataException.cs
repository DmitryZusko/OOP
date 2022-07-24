namespace Task_6
{
    using System;

    class TooManyDataException : Exception
    {

        public TooManyDataException() : base() 
        {
            Console.WriteLine("User's exception!");
        }
        public TooManyDataException(string message) : base(message) 
        {
            Console.WriteLine("User's exception!");
        }
        public TooManyDataException(string message, Exception innerException) : base(message, innerException) 
        {
            Console.WriteLine("User's exception!");
        }
    }
}
