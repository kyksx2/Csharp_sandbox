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

-----------------------------------------------------------------------------------
notes perso --> differenes entre class et record:
les classes sont penser penser pour definir un objet changeant, on peut changer et faire evoluer des donnes, 2 objets avec les memes donnees ne sont pas identiques
- exemple:
- var classe1 = new PersonneClass { Nom = "Alice" };
- var classe2 = new PersonneClass { Nom = "Alice" };
- Console.WriteLine(classe1 == classe2); --> Faux

Au contraire, un record creer des instances imuables conceptualiser pour encapsuler des donnees, si les donnees sont identiques, un record sera egale a un autre
- exemple:
- var record1 = new PersonneRecord("Alice");
- var record2 = new PersonneRecord("Alice");
- Console.WriteLine(record1 == record2); --> Vrai

exemple concret avec dark souls 2:
- classe = un personnage, il a des stats et un inventaire qui peuvent changer
- record = les gemmes de vie ou couteau de lancer, ils peuvent s'entasser dans l'inventaire et ne change pas