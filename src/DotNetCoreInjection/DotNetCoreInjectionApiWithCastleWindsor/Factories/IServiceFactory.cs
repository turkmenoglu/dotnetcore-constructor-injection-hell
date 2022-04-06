using DotNetCoreInjectionApiWithCastleWindsor.Services;

namespace DotNetCoreInjectionApiWithCastleWindsor.Factories
{
    public interface IServiceFactory
    {
        IWinterService CreateWinterService();
        ISpringService CreateSpringService();
        ISummerService CreateSummerService();
        IAutumnService CreateAutumnService();
    }
}
