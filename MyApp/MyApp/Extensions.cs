using System.Threading.Tasks;

namespace MyApp
{
    public static class Extensions
    {
        public static string ToString(this string text)
        {
            Task.Delay(3000);
            return text;
        }
    }
}
