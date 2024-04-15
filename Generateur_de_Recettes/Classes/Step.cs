using System.Runtime.InteropServices.JavaScript;

namespace Generateur_de_Recettes.Classes;

public class Step
{
    public int NumberStep { get; set; }
    public string TextStep { get; set; }

    public Step()
    {
        NumberStep = 0;
        TextStep = "";
    }

    public Step(int initNumber, string initText)
    {
        NumberStep = initNumber;
        TextStep = initText;
    }
}