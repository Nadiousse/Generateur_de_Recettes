using Generateur_de_Recettes.Enumerations;

namespace Generateur_de_Recettes.Classes;

public class Ingredient
{
    public string Name { get; set; }
    public IngredientCategory Category { get; set; }
    public Aisle AisleCategory { get; set; }

    public Ingredient()
    {
    }
    
    public Ingredient(string initName)
    {
        Name = initName;
        Category = IngredientCategory.Other;
        AisleCategory = Aisle.Other;
        
        Database.ListIngredients.Add(this);
    }
}