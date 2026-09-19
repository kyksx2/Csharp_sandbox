# Module 2 — LINQ et manipulation de collections

## Objectifs
- Remplacer les boucles impératives (`for`, `foreach`) par des pipelines déclaratifs.
- Maîtriser les méthodes de filtrage, projection, tri et agrégation LINQ.

## Consignes

1. **Modèle de données :**
   - Déclare le record suivant :
     ```csharp
     record Produit(int Id, string Nom, string Categorie, decimal Prix, bool EnStock);
     ```

2. **Jeu de données :**
   - Crée une `List<Produit>` contenant au moins six éléments répartis sur deux catégories (ex. `"Informatique"` et `"Bureau"`), avec des prix variés et certains produits avec `EnStock = false`.

3. **Requêtes LINQ :**
   Écris les requêtes suivantes en utilisant **exclusivement** les méthodes d'extension LINQ :
   - **Filtrage et tri :** Récupérer tous les produits en stock de la catégorie `"Informatique"`, triés du plus cher au moins cher (`.Where()`, `.OrderByDescending()`).
   - **Projection :** Extraire une nouvelle liste ne contenant que le nom des produits dont le prix est supérieur à 50 € (`.Where()`, `.Select()`, `.ToList()`).
   - **Recherche unitaire :** Trouver le premier produit coûtant moins de 20 €, ou `null` s'il n'en existe aucun (`.FirstOrDefault()`).
   - **Validation de condition :** Vérifier s'il existe au moins un produit en rupture de stock dans toute la liste (`.Any()`).

4. **Affichage :**
   - Affiche le résultat de chaque opération dans la console.