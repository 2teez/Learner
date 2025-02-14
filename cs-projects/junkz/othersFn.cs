namespace OtherFunctions
{
    static class Printer
    {
        public static void Pp(this object obj, Action<object> p = null)
        {
            p ??= Console.WriteLine;
            p(obj);
        }
    }

    static class StrUtil
    {
        public static string First(this string obj)
        {
            if (obj.Length == 0)
            {
                throw new Exception("Can't be empty.");
            }
            return obj.Substring(0, 1);
        }

        public static string Last(this string obj)
        {
            var result = "";
            if (obj.Length == 0)
            {
                throw new Exception("Can't be empty.");
            }
            else if (obj.Length == 1)
            {
                result = obj.Substring(0, 1);
            }
            else
            {
                result = obj.Substring(obj.Length - 1);
            }
            return result;
        }
    }
}
