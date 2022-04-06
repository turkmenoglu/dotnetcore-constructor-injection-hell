using DotNetCoreInjectionApiWithInjectionTypedFactories.Services;

namespace DotNetCoreInjectionApiWithInjectionTypedFactories.Factories
{
    public interface IServiceFactory
    {
        IWinterService CreateWinterService();
        ISpringService CreateSpringService();
        ISummerService CreateSummerService();
        IAutumnService CreateAutumnService();
    }
}
