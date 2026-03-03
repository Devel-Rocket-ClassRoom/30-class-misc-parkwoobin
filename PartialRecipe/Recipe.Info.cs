public partial class Recipe
{
    public string Name { get; }
    public int Servings { get; }

    private readonly string[] ingredients;
    private int ingredientCount;

    public Recipe(string name, int servings, int maxIngredients)
    {
        Name = name;
        Servings = servings;
        ingredients = new string[maxIngredients];
        ingredientCount = 0;
    }
}
