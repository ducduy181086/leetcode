// See https://aka.ms/new-console-template for more information
using container_with_most_water;

using PracticeLibrary.Helpers;

var writer = Console.Out;
var cases = await GetCases(CancellationToken.None);
var solution = new Solution();
foreach (var item in cases) {
    writer.WriteLine("height =");
    item.Print(writer);
    writer.WriteLine("Output");
    writer.WriteLine(solution.MaxArea(item));
}

async Task<ICollection<int[]>> GetCases(CancellationToken cancellation) {
    var result = new List<int[]>();
    var readers = TestHelper.GetTestReaders();
    foreach (var reader in readers) {
        result.Add(await reader.GetIntArrayAsync(cancellation));
    }

    return result;
}
