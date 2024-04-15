using Generateur_de_Recettes.Enumerations;

namespace Generateur_de_Recettes.Classes;

public class Ingredient
{
    public string Name { get; set; }
    public IngredientCategory Category { get; set; }
    public Aisle AisleCategory { get; set; }

    public Ingredient()
    {
        Name = "";
        Category = IngredientCategory.Other;
        AisleCategory = Aisle.Other;
    }
    
    public Ingredient(string initName, IngredientCategory initIngredientCategory, Aisle initAisleCategory)
    {
        Name = initName;
        Category = initIngredientCategory;
        AisleCategory = initAisleCategory;
    }
}