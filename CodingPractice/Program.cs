using System;
using System.ComponentModel;
using System.Linq;
using System.Text;

// README.md를 읽고 아래에 코드를 작성하세요.


Person person = new Person();
person.Name = "홍길동";
person.Age = 25;
person.Print();

Hello hello = new Hello();
hello.Hi();
hello.Bye();

Console.WriteLine($"덧셈: {Calculator.Add(5, 3)}");
Console.WriteLine($"뺄셈: {Calculator.Subtract(5, 3)}");
Console.WriteLine($"곱셈: {Calculator.Multiply(5, 3)}");

string input = "  Hello World!  ";
Console.WriteLine($"{StringHelper.CleanAndUpper(input)}");
Console.WriteLine($"{StringHelper.Reverse("Hello")}");
Console.WriteLine(StringHelper.IsNullOrEmpty(""));

Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
Console.WriteLine($"최솟값: {Math.Min(10, 20)}");


string sb = new StringBuilder()
.Append("Hello World")
.AppendLine()
.Append("Hello World")
.ToString();

Console.WriteLine(sb);

string message = new MessageBuilder()
.AddText("안녕하세요!")
.AddNewLine()
.AddText("반갑습니다.")
.AddSpace()
.AddText("즐거운 하루 되세요.")
.Build();

Console.WriteLine(message);

Point point = new Point(0, 0)
.MoveBy(10, 10)
.MoveBy(20, 20)
.MoveBy(30, 30);

Console.WriteLine(point);


string message1 = "  Hello World  ";

string text = message1
.Trim()
.ToLower()
.Replace(" ", "_");

Console.WriteLine(text);

MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");
circle.Radius = 20;
Console.WriteLine($"반지름: {circle.Radius}");

ImmutableCircle Circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {Circle1.Radius}");
ImmutableCircle newCircle = Circle1.WithRadius(20);
Console.WriteLine($"새 원 반지름: {newCircle.Radius}");
Console.WriteLine($"원본 반지름: {Circle1.Radius}");

Player player = new Player("용사", 1);
Console.WriteLine($"player1: {player.Name}, 레벨: {player.Level}");

Player player2 = player.LevelUp();
Console.WriteLine($"player2: {player2.Name}, 레벨: {player2.Level}");

string original = "Hello World";
string modified = original.ToUpper();

Console.WriteLine($"원본: {original}");
Console.WriteLine($"수정본: {modified}");

Character character = new Character("용사", 100, 1);
Console.WriteLine($"{character._name} - 레벨: {character._level}, 체력: {character._health}");
Console.WriteLine($"{character._name}이(가) 30의 피해를 입음. 남은 체력 {character.TakeDamage(30)}");
Console.WriteLine($"{character._name}이(가) 10만큼 회복함. 현재 체력 {character.Heal(10)}");

int damage = GameHelper.CalculateDamage(10, 5);
bool isAlive = GameHelper.IsAlive(50);
string status = GameHelper.GetHealthStatus(30, 100);
Console.WriteLine($"계산된 데미지: {damage}");
Console.WriteLine($"생존 여부: {isAlive}");
Console.WriteLine($"체력 상태: {status}");

Vector2D vector1 = new Vector2D(1, 1)
.Add(2, 3)
.Multiply(2)
.Add(-1, -2);

Console.WriteLine($"결과 벡터: {vector1}");



public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요!");
    }
}
public partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }
    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
}
public class MessageBuilder
{
    private string _message = "";

    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;
    }
    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }
    public MessageBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }
    public string Build()
    {
        return _message;
    }
}

public class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point MoveBy(int dx, int dy)
    {
        return new Point(X + dx, Y + dy);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class MutableCircle
{
    public int Radius { get; set; }
    public MutableCircle(int radius)
    {
        Radius = radius;
    }
}

public class ImmutableCircle
{
    public int Radius { get; }
    public ImmutableCircle(int radius)
    {
        Radius = radius;
    }
    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}

public class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public Player LevelUp()
    {
        return new Player(Name, Level + 1);
    }
}

partial class Character
{
    public string _name;
    public int _health;
    public int _level;
    public Character(string name, int health, int level)
    {
        _name = name;
        _health = health;
        _level = level;
    }
}

partial class Character
{
    public int TakeDamage(int damage)
    {
        _health -= damage;
        return _health;
    }
    public int Heal(int amount)
    {
        _health += amount;
        return _health;
    }
}

static class GameHelper
{
    public static int CalculateDamage(int baseDamage, int level)
    {
        return baseDamage + (level * 5);
    }
    public static bool IsAlive(int health)
    {
        return health > 0;
    }
    public static string GetHealthStatus(int health, int maxHealth)
    {
        if (maxHealth <= 0) return health > 0 ? "오류" : "사망";
        double ratio = (double)health / maxHealth;
        if (ratio > 0.7) return "양호";
        if (ratio > 0.3) return "주의";
        if (ratio > 0) return "위험";
        return "사망";
    }
}
public class Vector2D
{
    public readonly double X;
    public readonly double Y;

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }
    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}