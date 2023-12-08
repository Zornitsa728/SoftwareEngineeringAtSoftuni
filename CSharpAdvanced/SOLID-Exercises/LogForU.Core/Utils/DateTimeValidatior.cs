using System.Globalization;

namespace LogForU.Core.Utils
{
    public static class DateTimeValidatior
    {
        private static readonly ISet<string> formats =
            new HashSet<string> { "M/dd/yyyy h:mm:ss tt" };

        public static void AddFormat(string format) => formats.Add(format);
        public static bool ValidateDateTimeFormat(string dateTime)
        {
            foreach (var format in formats)
            {
                if (DateTime.TryParseExact(
                dateTime,
                format,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime result))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
