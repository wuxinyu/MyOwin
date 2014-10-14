namespace Daemon
{
    using System;

    using Topshelf;

    public class Host
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
            });
            Console.Read();
        }
    }
}
