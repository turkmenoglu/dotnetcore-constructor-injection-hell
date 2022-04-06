namespace DotNetCoreInjectionApi.Services
{
    public class AutumnService : IAutumnService
    {
        public string[] GetMonths()
        {
            return new string[] { "September", "October", "November" };
        }
    }

    public interface IAutumnService
    {
        string[] GetMonths();
    }
}
