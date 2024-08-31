namespace PracticeLibrary.Helpers
{
    public static class TestHelper
    {
        public static IEnumerable<TextReader> GetTestReaders()
        {
            string executingPath = AppContext.BaseDirectory;
            var files = Directory.EnumerateFiles(Path.Combine(executingPath, "TestCases"), "Case*.txt");
            foreach (var file in files.OrderBy(m => int.Parse(Path.GetFileNameWithoutExtension(m).Substring(4))))
            {
                using var reader = File.OpenRead(file);
                using var stream = new StreamReader(reader);
                yield return stream;
            }
        }

        public static async Task<int[]> GetIntArrayAsync(this TextReader reader, CancellationToken cancellation)
        {
            var line = await reader.ReadLineAsync(cancellation);
            return (line ?? string.Empty).Split(',').Select(m => m.Trim()).Select(int.Parse).ToArray();
        }

        public static async Task<int> GetIntAsync(this TextReader reader, CancellationToken cancellation)
        {
            var line = await reader.ReadLineAsync(cancellation);
            return int.Parse(line ?? string.Empty);
        }
    }
}
