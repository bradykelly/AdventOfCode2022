namespace AdventOfCode.Console;

public class Day1
{
    private readonly List<int> _totals = new();
    
    public void Part1()
    {
        var subTotal = 0;
        
        var lines = File.ReadLines(@"C:\AdventOfCode\AdventOfCode.Data\Day1.txt");
        foreach (var line in lines)
        {
            if (line.Length == 0)
            {
                _totals.Add(subTotal);
                subTotal = 0;
                continue;
            }

            subTotal += int.Parse(line);
        }
        _totals.Add(subTotal);
        
        System.Console.WriteLine($"Max calories: {_totals.Max()}");
    }

    public void Part2()
    {
        Part1();

        var top3Total = _totals.OrderByDescending(t => t).Take(3).Sum();
        
        System.Console.WriteLine($"Top 3 calories: {top3Total}");
    }
}