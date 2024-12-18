using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            string answer;

            Console.WriteLine("Bonjour !");
            Console.WriteLine("Merci d'entrer votre premier nombre.");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Merci d'entrer votre deuxième nombre.");

            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Quel genre d'opération voulez-vous effectuer ?");
            Console.WriteLine("Entrez 'a' pour addition, 's' pour soustraction, 'm' pour multiplication, et 'd' pour division.");

            answer = Console.ReadLine() ?? string.Empty;

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("Le resultat est " + result);

            Console.WriteLine("Merci d'avoir utilisé notre calculatrice.");

            Console.ReadKey();
        }
    }
}
