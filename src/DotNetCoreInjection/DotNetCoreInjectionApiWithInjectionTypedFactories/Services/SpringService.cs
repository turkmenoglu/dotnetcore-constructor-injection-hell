namespace DotNetCoreInjectionApiWithInjectionTypedFactories.Services
{
    public class SpringService : ISpringService
    {
        public string[] GetMonths()
        {
            return new string[] { "March", "April", "May" };
        }
    }

    public interface ISpringService
    {
        string[] GetMonths();
    }
}
