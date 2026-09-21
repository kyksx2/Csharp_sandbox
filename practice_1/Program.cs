// See https://aka.ms/new-console-template for more information

using System.Reflection.Emit;
using System.Security.Cryptography;
using spaceforpractice1;

namespace practice_1
{
    class ProgramForCompteClass
    {
        static void Main(string[] args)
        {
            // comprendre les references et valeurs en fonction du comportemment
            RefAndVal();
            // ----------------------------------------------------------------------
            // operateur de coalescence des null
            OperatorCoalescence();
            // verification si email est null, si oui, on print la valeur entre ""
            // ---------------------------------
            // patern matching / utilisation de switch
            string? arg = args.Length > 0 ? args[0] : null; // -> if args > 0 function(args) else function(null)
            PaternMatching(arg);
            // ---------------------------------------
        }

        static void PaternMatching(string? arg)
        {
            Console.WriteLine("- patern matching -");
            static string ObtenirLibelleStatut(int codeHttp) {
                switch (codeHttp)
                {
                    case 200:
                        return "Succes";
                    case 404:
                        return "introuvable";
                    case 500:
                        return "Erreur serveur";
                    default:
                        return "code inconnu";
                }
            }
            int.TryParse(arg, out int code); // parsing de la string puis transformation en int dans 'code'
            Console.WriteLine(ObtenirLibelleStatut(code));
            Console.WriteLine("-------------------");
        }

        static void RefAndVal()
        {            
            Console.WriteLine("- references et valeurs -");
            CompteClass c1 = new CompteClass(1, 100);
            CompteClass c2 = c1;
            c2.Solde = 200;
            Console.WriteLine($"c1 after changing c2 = {c1.Solde}"); // maniere d'ecrire
            ProgramForCompteRecord.EntryForRecord();
            Console.WriteLine("-------------------------");
        }

        static void OperatorCoalescence()
        {
            Console.WriteLine("- operateur de coalescence -");
            string? email = null;
            Console.WriteLine($"the mail is : " + (email ?? "null"));
            Console.WriteLine("----------------------------");
        }
    }

    class ProgramForCompteRecord
    {
        public static void EntryForRecord()
        {
            CompteRecord r1 = new CompteRecord(1, 100);
            CompteRecord r2 = r1 with { Solde = 200 };
            Console.WriteLine("r1 solde = " + r1.Solde); // autre maniere d'ecrire
            Console.WriteLine("r2 solde = " + r2.Solde);
        }
    }
}
// https://learn.microsoft.com/fr-fr/dotnet/csharp/tour-of-csharp/what-you-can-build
