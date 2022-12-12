string sample = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

int maxCalories = sample.Split("\n\n")
    .Max(elf =>
    elf.Split("\r\n")
    .Sum(int.Parse)
    );

Console.WriteLine($"Part 1: {maxCalories}");