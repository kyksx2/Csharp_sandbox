// See https://aka.ms/new-console-template for more information
using System;

namespace practice_2 {
  record Produit(int Id, string Nom, string Categorie, decimal Prix, bool EnStock);

  class Practice {
    static void Main(string[] args)
    {
      List<Produit> produits = [        
        new Produit(1, "carte", "informatique", 12, false),
        new Produit(2, "pc", "informatique", 888, true),
        new Produit(3, "cable", "informatique", 14, true),
        new Produit(4, "trombones", "bureau", 2, true),
        new Produit(5, "imprimante", "bureau", 554, true),
        new Produit(6, "scotch", "bureau", 9, false),
      ];

      // foreach (var prod in produits)
      // {
      //   Console.WriteLine(prod);
      // }
      //----------------Filtrage et tri-------------------
      var reqOne = produits
          .Where(prod => prod.Categorie == "informatique")
          .OrderByDescending(prod => prod.Prix);
      foreach (var pr in reqOne)
        Console.WriteLine(pr);
      //---------------------------------------------------
      //--Projection--
      //--------------
      //--Recherche unitaire--
      //----------------------
      //--Validation de condition--
      //---------------------------
    }
  }
}
