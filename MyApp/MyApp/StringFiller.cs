using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class StringFiller
    {
        public string GetString(string textIn, int length)
        {
            var output = "";
            var text = textIn.ToList();
            output = GetText(length, output, text);
            return output;
        }

        private static string GetText(int length, string output, List<char> text)
        {
            for (var j = 0; j < text.Count(); j++)
            {
                output = GetRepeatedCharacters(length, output, text, j);
            }

            return output;
        }

        private static string GetRepeatedCharacters(int length, string output, List<char> text, int j)
        {
            for (var i = 0; i < (GetRepeatCount(length, text)); i++)
            {
                output += CharIfNotTooLong(length, output, text, j);
            }

            return output;
        }

        private static int GetRepeatCount(int length, List<char> text)
                => length >= text.Count()
                    ? length / text.Count()
                    : 1;

        private static string CharIfNotTooLong(int length,
                                               string output,
                                               List<char> text,
                                               int j)
            => output.Count() <= length
                ? text[j].ToString()
                : "";
    }
}
