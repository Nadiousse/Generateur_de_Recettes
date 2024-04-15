namespace Generateur_de_Recettes.Classes;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> IngredientsList { get; set; }
    public int StepsNumber { get; set; }
    public List<Step> StepsList { get; set; }

    public Recipe()
    {
        Name = "";
        IngredientsList = new List<Ingredient>();
        StepsNumber = 0;
        StepsList = new List<Step>();
    }

    public Recipe(string initName)
    {
        Name = initName;
        IngredientsList = new List<Ingredient>();
        StepsNumber = 0;
        StepsList = new List<Step>();
    }
}