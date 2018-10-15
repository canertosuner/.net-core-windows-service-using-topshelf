using Topshelf;

namespace NetCoreTopshelf.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(hostConfig =>
            {
                hostConfig.Service<HelloWorldServiceHost>(serviceConfig =>
                {
                    serviceConfig.ConstructUsing(() => new HelloWorldServiceHost());
                    serviceConfig.WhenStarted(s => s.Start());
                    serviceConfig.WhenStopped(s => s.Stop());
                });
                hostConfig.RunAsLocalSystem();
                hostConfig.SetServiceName("Hello World Service");
                hostConfig.SetDisplayName("Hello World Service Host");
                hostConfig.SetDescription("Hello World Service Host using .Net Core and Topshelf.");
            });
        }
    }
}
