// See https://aka.ms/new-console-template for more information

using integer_to_roman;

using PracticeLibrary.Helpers;

var writer = Console.Out;
var cases = await GetCases(CancellationToken.None);
var solution = new Solution();
foreach (var item in cases)
{
    writer.WriteLine("num =");
    writer.WriteLine(item);
    writer.WriteLine("Output");
    writer.WriteLine(solution.IntToRoman(item));
}

async Task<ICollection<int>> GetCases(CancellationToken cancellation)
{
    var result = new List<int>();
    var readers = TestHelper.GetTestReaders();
    foreach (var reader in readers)
    {
        result.Add(await reader.GetIntAsync(cancellation));
    }

    return result;
}
