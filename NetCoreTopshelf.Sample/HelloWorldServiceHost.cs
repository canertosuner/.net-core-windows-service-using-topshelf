using System;

namespace NetCoreTopshelf.Sample
{
    public class HelloWorldServiceHost
    {
        public void Start()
        {
            Console.WriteLine("Hello World Service Started !!");
        }

        public void Stop()
        {
            Console.WriteLine("Hello World Service Stopped !!");
        }
    }
}
