using CustomStringException;
using System.Text;

namespace StringFunctionsTest
{
    public class StringExtraFunctions
    {
        private static string StripStringPuntucations(string str)
        {
            if (char.IsPunctuation(str[str.Length - 1]))
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        private static string GenerateLatinWord(string str)
        {
            if (str.Length <= 1)
            {
                throw new StringLengthException();
            }
            return (str.Substring(1) + str.Substring(0, 1) + "ay");
        }

        public static string ReversePigLatin(string str)
        {
            var ayWord = str.Substring(str.Length - 2);
            var wrd = str.Substring(0, str.Length - 2);
            if (wrd.Length == 1)
                throw new CustomStringException.StringLengthException("Not a PigLatin Word.");
            return wrd[wrd.Length - 1] + wrd.Substring(0, wrd.Length - 1);
        }

        public static string GetPigLatin(string str)
        {
            var sb = new StringBuilder();
            foreach (var word in str.Split())
            {
                if (word.Length == 1) continue;
                sb.Append(GenerateLatinWord(StripStringPuntucations(word)) + " ");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
