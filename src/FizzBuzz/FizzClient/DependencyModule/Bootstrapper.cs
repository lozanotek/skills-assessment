using Autofac;
using FizzLib.Services;
using FizzLib.Wrappers;

namespace FizzClient.DependencyModule
{
    public class Bootstrapper
    {
        public static IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FizzBuzz>()
                .As<IFizzBuzz>();
            builder.RegisterType<ConsoleWrapper>()
                .As<IConsoleWrapper>();

            return builder.Build();
        }
    }
}
