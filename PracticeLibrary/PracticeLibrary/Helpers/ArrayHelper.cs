using System.Text;

namespace PracticeLibrary.Helpers
{
    public static class ArrayHelper
    {
        public static T[] Input<T>(params T[] values)
        {
            return values;
        }

        public static void Print<T>(this T[] values, TextWriter writer)
        {
            var sb = new StringBuilder();
            sb.Append('[');
            bool first = true;
            foreach (var value in values)
            {
                if (!first) { sb.Append(", "); }
                else { first = false; }
                sb.Append(value);
            }

            sb.Append(']');
            writer.WriteLine(sb.ToString());
        }
    }
}
