namespace DotNetCoreInjectionApiWithInjectionTypedFactories.Services
{
    public class WinterService : IWinterService
    {
        public string[] GetMonths()
        {
            return new string[] { "December", "January", "February" };
        }
    }

    public interface IWinterService
    {
        string[] GetMonths();
    }
}
