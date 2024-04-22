using Generateur_de_Recettes.Enumerations;

namespace Generateur_de_Recettes.Classes;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> IngredientsList { get; set; }
    public int StepsNumber { get; set; }
    public List<string> StepsList { get; set; }

    public Recipe()
    {
    }

    public Recipe(string initName)
    {
        Name = initName;
        IngredientsList = new List<Ingredient>();
        StepsList = new List<string>();

        InitializeFullRecipe();
    }

    public void InitializeFullRecipe()
    {
        int numberOfIngredients = AskNumberOfItems();
        
        AddIngredients(numberOfIngredients);
    }

    public int AskNumberOfItems()
    {
        return 0; //-----------A voir pour ajouter le choix du nombre d'items-------------------------------------------
    }

    public void AddIngredients(int NumberOfIngredients)
    {
        for (int i = 0; i < NumberOfIngredients; i++)
        {
            Ingredient ingredientToAdd = new Ingredient("initName"); //----Ajouter les entrées formulaires-------

            IngredientsList.Add(ingredientToAdd); 
        }   
    }

    public void AddSteps(int initNumberOfSteps)
    {
        for (int i = 0; i < initNumberOfSteps; i++)
        {
            string tempStep = ""; //-----------A voir comment ajouter l'ajout de toutes les étapes avec WPF-------------
            
            StepsList.Add(tempStep);
        }
    }
}