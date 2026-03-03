using System;

Console.WriteLine("=== Clamp 테스트 ===");
Console.WriteLine($"Clamp(-10, 0, 100) = {GameUtils.Clamp(-10, 0, 100)}");
Console.WriteLine($"Clamp(50, 0, 100) = {GameUtils.Clamp(50, 0, 100)}");
Console.WriteLine($"Clamp(150, 0, 100) = {GameUtils.Clamp(150, 0, 100)}");
Console.WriteLine();

Console.WriteLine("=== GetPercentage 테스트 ===");
Console.WriteLine($"GetPercentage(75, 100) = {GameUtils.GetPercentage(75, 100)}%");
Console.WriteLine($"GetPercentage(30, 200) = {GameUtils.GetPercentage(30, 200)}%");
Console.WriteLine();

Console.WriteLine("=== IsInRange 테스트 ===");
Console.WriteLine($"IsInRange(50, 0, 100) = {GameUtils.IsInRange(50, 0, 100)}");
Console.WriteLine($"IsInRange(-5, 0, 100) = {GameUtils.IsInRange(-5, 0, 100)}");
Console.WriteLine($"IsInRange(150, 0, 100) = {GameUtils.IsInRange(150, 0, 100)}");

public static class GameUtils
{
    public static int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            return min;
        }

        if (value > max)
        {
            return max;
        }

        return value;
    }

    public static int GetPercentage(int current, int max)
    {
        return current * 100 / max;
    }

    public static bool IsInRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }
}
