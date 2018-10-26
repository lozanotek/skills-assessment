using Autofac;
using FizzLib.Services;

namespace FizzClient.DependencyModule
{
    public class Bootstrapper
    {
        public static IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FizzBuzz>()
                .As<IFizzBuzz>();

            return builder.Build();
        }
    }
}
