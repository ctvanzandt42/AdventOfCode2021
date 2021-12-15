namespace Day02;

public static class Program
{
    public static void Main(string[] args)
    {
        var input = File.ReadAllLines("../../../daytwo.txt");

        Console.WriteLine("Day 2 Solutions");
        Console.WriteLine(PartOne(input));
        Console.WriteLine(PartTwo(input));
    }

    private static int PartOne(IEnumerable<string> report)
    {
        var depth = 0;
        var position = 0;

        foreach (var line in report)
        {
            var strSplit = line.Split(" ");
            if (strSplit[0] == "forward")
            {
                position += int.Parse(strSplit[1]);
            }

            if (strSplit[0] == "up")
            {
                depth -= int.Parse(strSplit[1]);
            }

            if (strSplit[0] == "down")
            {
                depth += int.Parse(strSplit[1]);
            } 
        }

        return depth * position;
    }
    
    private static int PartTwo(IEnumerable<string> report)
    {
        var depth = 0;
        var position = 0;
        var aim = 0;

        foreach (var line in report)
        {
            var strSplit = line.Split(" ");
            if (strSplit[0] == "forward")
            {
                position += int.Parse(strSplit[1]);
                depth += aim * int.Parse(strSplit[1]);
            }

            if (strSplit[0] == "up")
            {
                aim -= int.Parse(strSplit[1]);
            }

            if (strSplit[0] == "down")
            {
                aim += int.Parse(strSplit[1]);
            } 
        }

        return depth * position;
    }
}