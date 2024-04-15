namespace Generateur_de_Recettes.Classes;

public static class Database
{
    private static string fileName = "database.xml";
    private static string filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\xml\" + fileName;
    
    public static List<Ingredient> ListIngredients { get; set; }
    public static List<Recipe> ListRecipes { get; set; }
    
}