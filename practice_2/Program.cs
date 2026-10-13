// See https://aka.ms/new-console-template for more information
using System;

namespace practice_2 {
  record Produit(int Id, string Nom, string Categorie, decimal Prix, bool EnStock);

  class Practice {
    static void Main(string[] args)
    {
      List<Produit> produits = [        
        new Produit(1, "carte", "informatique", 9, true),
        new Produit(2, "pc", "informatique", 888, true),
        new Produit(3, "cable", "informatique", 124, true),
        new Produit(4, "trombones", "bureau", 22, true),
        new Produit(5, "imprimante", "bureau", 554, false),
        new Produit(6, "scotch", "bureau", 29, true),
      ];

      // foreach (var prod in produits)
      // {
      //   Console.WriteLine(prod);
      // }
      Console.WriteLine("-- Filtrage et tri --");
      //----------------Filtrage et tri-------------------
      var reqOne = produits
          .Where(prod => prod.Categorie == "informatique" && prod.EnStock)
          .OrderByDescending(prod => prod.Prix);
      foreach (var pr in reqOne)
        Console.WriteLine($"{pr.Nom}; {pr.Categorie}; {pr.Prix}");
      //---------------------------------------------------

      Console.WriteLine("-- Projection --");
      //--Projection--
      var reqTwo = produits
          .Where(proj => proj.Prix > 50)
          .Select(proj => proj.Nom)
          .ToList();
      foreach(var proj in reqTwo)
        Console.WriteLine(proj);
      //--------------
      Console.WriteLine("-- Recherche unitaire --");
      //--Recherche unitaire--
      var reqThree = produits
          .FirstOrDefault(prod => prod.Prix < 20);
      if (reqThree == null)
        Console.WriteLine("recherche unitaire: vide");
      else
        Console.WriteLine(reqThree.Nom);
      //----------------------

      Console.WriteLine("-- Validation de condition --");
      //--Validation de condition--
      var reqFour = produits
          .Any(prod => prod.EnStock == false);
      Console.WriteLine(reqFour);
      //---------------------------
    }
  }
}
