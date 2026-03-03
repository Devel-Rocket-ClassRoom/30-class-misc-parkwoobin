using System;

public partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if (ingredientCount >= ingredients.Length)
        {
            Console.WriteLine("재료를 더 추가할 수 없습니다.");
            return;
        }

        ingredients[ingredientCount++] = ingredient;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");

        for (int i = 0; i < ingredientCount; i++)
        {
            Console.WriteLine($"  {i + 1}. {ingredients[i]}");
        }

        Console.WriteLine();
    }

    public bool HasIngredient(string ingredient)
    {
        for (int i = 0; i < ingredientCount; i++)
        {
            if (ingredients[i] == ingredient)
            {
                return true;
            }
        }

        return false;
    }
}