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
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void Start()
        {
            var itemsManager = new ItemsManager();
            itemsManager.Start();
        }
    }
}