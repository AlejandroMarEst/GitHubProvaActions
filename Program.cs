using System;
namespace ProvaGitHubActions
{
    public class ProvaGitHubActions
    {
        public static void Main()
        {
            const string MSG1 = "Hola! Inserta el teu nom:";
            const string MSG2 = "Hola {0}!";
            const string ErrorMsg = "El valor introduit no es valid: ";
            string nameUser;
            Console.WriteLine(MSG1);
            try
            {
                nameUser = Console.ReadLine();
                Console.WriteLine(MSG2, nameUser);
                Console.WriteLine(MSG3);
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorMsg);
            }
        }
    }
}