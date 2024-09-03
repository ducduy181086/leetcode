// See https://aka.ms/new-console-template for more information
using PracticeLibrary.Helpers;

using single_element_in_a_sorted_array;

var writer = Console.Out;
var cases = await GetCases(CancellationToken.None);
var solution = new Solution();
foreach (var item in cases) {
    writer.WriteLine("nums =");
    item.Print(writer);
    writer.WriteLine("Output");
    writer.WriteLine(solution.SingleNonDuplicate(item));
}

async Task<ICollection<int[]>> GetCases(CancellationToken cancellation) {
    var result = new List<int[]>();
    var readers = TestHelper.GetTestReaders();
    foreach (var reader in readers) {
        result.Add(await reader.GetIntArrayAsync(cancellation));
    }

    return result;
}
