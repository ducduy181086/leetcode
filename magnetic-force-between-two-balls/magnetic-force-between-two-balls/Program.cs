// See https://aka.ms/new-console-template for more information
using magnetic_force_between_two_balls;

using PracticeLibrary.Helpers;

var writer = Console.Out;
var cases = await GetCases(CancellationToken.None);
var solution = new Solution();
foreach (var (position, m) in cases)
{
    writer.WriteLine("position =");
    position.Print(writer);
    writer.WriteLine("m =");
    writer.WriteLine(m);
    writer.WriteLine("Result =");
    writer.WriteLine(solution.MaxDistance(position, m));
}

async Task<ICollection<(int[] position, int m)>> GetCases(CancellationToken cancellation)
{
    var result = new List<(int[] position, int m)>();
    var readers = TestHelper.GetTestReaders();
    foreach (var reader in readers)
    {
        var position = await reader.GetIntArrayAsync(cancellation);
        var m = await reader.GetIntAsync(cancellation);
        result.Add((position, m));
    }

    return result;
}
