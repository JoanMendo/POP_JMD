using System;

namespace PoPMenu;

public class PopProject
{
    public static void Main(string[] args)
    {
       const string  StartingMsg = "A. Saltar\r\nB. Córrer\r\nC. Ajupir-se\r\nD. Amagar-se";

        Console.WriteLine(StartingMsg);
        string option = Console.ReadLine();
        bool validAction = ValidateAction(option);
    }

    public static bool ValidateAction (string action)
    {
        action = action.ToUpper();

        switch (action)
        {
            case "A":
                Console.WriteLine("Has saltat");
                return true;
            case "B":
                Console.WriteLine("Has corregut");
                    return true;
            case "C":
                Console.WriteLine("T'has ajupit");
                return true;
            case "D":
                Console.WriteLine("T'has amagat");
                return true;
            default:
            Console.WriteLine("No has fet res perque no saps escriure A, B, C, o D");
                return false;
        }
    }

}