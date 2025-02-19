namespace MyCookBookApp.Models
{
    public class RecipeMedia
{
    public string Url { get; set; }
    public string Type { get; set; }  // e.g., "image" or "video"
    public int Order { get; set; }    // Display order
}

}