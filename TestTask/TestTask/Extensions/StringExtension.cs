using System.Text;

namespace TestTask.Extensions
{
    public static class StringExtension
    {
        public static string Swap(this string value, int firstIndex, int lastIndex)
        {
            StringBuilder stringBuilder = new StringBuilder(value);
            stringBuilder[firstIndex] = value[lastIndex];
            stringBuilder[lastIndex] = value[firstIndex];

            return stringBuilder.ToString();
        }
    }
}
