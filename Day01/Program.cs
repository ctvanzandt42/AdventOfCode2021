namespace Day01;

public static class Program
{
    public static void Main(string[] args)
    {
        var report = Array.ConvertAll(File.ReadAllLines("../../../dayone.txt"), int.Parse);
        
        Console.WriteLine(PartOne(report));
        Console.WriteLine(PartTwo(report));
    }

    private static int PartOne(IReadOnlyList<int> report)
    {
        var counter = 0;

        for (var i = 1; i < report.Count; i++)
        {
            if (report[i] > report[i - 1])
            {
                counter++;
            }
        }

        return counter;
    }
    
    private static int PartTwo(IReadOnlyList<int> report)
    {
        var counter = 0;

        for (var i = 1; i < report.Count; i++)
        {
            try
            {
                var currentSum = report[i] + report[i + 1] + report[i + 2];
                var prevSum = report[i - 1] + report[i] + report[i + 1];
                if (currentSum > prevSum)
                {
                    counter++;
                }
            }
            catch (ArgumentOutOfRangeException) {}
        }

        return counter;
    }
}