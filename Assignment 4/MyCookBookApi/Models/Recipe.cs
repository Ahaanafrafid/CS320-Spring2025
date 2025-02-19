public class Recipe
{
    public string RecipeId { get; set; }  // Auto-generated unique ID
    public string Name { get; set; }
    public string TagLine { get; set; }
    public string Summary { get; set; }
    public List<string> Instructions { get; set; } = new List<string>();
    public List<string> Ingredients { get; set; } = new List<string>();
    public List<CategoryType>? Categories { get; set; }
    public List<RecipeMedia>? Media { get; set; }
}
