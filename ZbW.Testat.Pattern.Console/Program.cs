namespace ZbW.Testat.Pattern.Console
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Start();
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                Console.ReadLine();
            }
        }

        private static void Start()
        {
            throw new NotImplementedException();
        }
    }
}