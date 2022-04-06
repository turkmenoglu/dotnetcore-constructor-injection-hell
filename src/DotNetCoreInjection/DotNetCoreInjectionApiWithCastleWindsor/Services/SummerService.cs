namespace DotNetCoreInjectionApiWithCastleWindsor.Services
{
    public class SummerService : ISummerService
    {
        public string[] GetMonths()
        {
            return new string[] { "June", "July", "August" };
        }
    }

    public interface ISummerService
    {
        string[] GetMonths();
    }
}
