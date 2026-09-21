**T# Module 1 — Types, références et nullabilité

## Objectifs
- Comprendre la différence de comportement mémoire entre `class` (référence) et `record` (valeur/immuabilité).
- Manipuler la syntaxe moderne de gestion du `null` (`string?`, opérateur `??`).
- Découvrir les expressions `switch`.

## Consignes

1. **Déclarations :**
   - Crée une classe `CompteClass` avec deux propriétés : `Id` (entier) et `Solde` (`decimal`).
   - Crée un record `CompteRecord` avec les deux mêmes propriétés (`Id` et `Solde`).

2. **Test référence vs valeur :**
   - Instancie `c1` (`CompteClass`) avec `Id = 1` et `Solde = 100m`.
   - Instancie `r1` (`CompteRecord`) avec `Id = 1` et `Solde = 100m`.
   - Crée une variable `c2 = c1`, modifie `c2.Solde = 200m`, puis affiche `c1.Solde`. Observe le résultat.
   - Crée une variable `r2 = r1 with { Solde = 200m }`, puis affiche `r1.Solde` et `r2.Solde`.

3. **Opérateur de coalescence des nuls :**
   - Déclare une variable `string? email = null;`.
   - Affiche sa valeur en utilisant l'opérateur `??` pour que la console écrive `"email non renseigné"` si la variable est nulle.

4. **Pattern matching :**
   - Écris une fonction locale ou statique `string ObtenirLibelleStatut(int codeHttp)` utilisant une **expression switch** pour renvoyer :
     - `200` -> `"Succès"`
     - `404` -> `"Introuvable"`
     - `500` -> `"Erreur serveur"`
     - Tout autre code (`_`) -> `"Code inconnu"`
   - Teste la fonction avec plusieurs valeurs.ypes, references et nullabilité**