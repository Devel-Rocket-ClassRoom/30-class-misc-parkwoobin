using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Money money1 = new Money(100, 50);

Console.WriteLine("=== 초기 화폐 ===");
Console.WriteLine($"{money1}\n");

Console.WriteLine("=== 화폐 추가 ===");
Money money2 = money1.Add(50, 30);
Console.WriteLine($"지갑 {money2}");
Console.WriteLine($"원본 {money1}\n");

Console.WriteLine("=== 화폐 차감 ===");
Money money3 = money2.Subtract(70, 60);
Console.WriteLine($"지갑 {money3}");
Console.WriteLine($"원본 {money1}\n");


Console.WriteLine("=== 메서드 체이닝 ===");
Money money4 = new Money(100, 50)
    .Add(80, 10)
    .Subtract(60, 30);
Console.WriteLine($"결과: {money4}");


public class Money
{
    public int Gold { get; }
    public int Silver { get; }

    public Money(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public Money Add(int gold, int silver)
    {
        return new Money(Gold + gold, Silver + silver);
    }
    public Money Subtract(int gold, int silver)
    {
        return new Money(Gold - gold, Silver - silver);
    }
    public override string ToString()
    {
        return $"지갑: {Gold} 골드 {Silver} 실버";
    }
}
