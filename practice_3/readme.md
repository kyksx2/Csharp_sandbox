# Module 3 — Asynchronisme et cycle de vie

## Objectifs
- Comprendre le comportement non bloquant de `async` et `await`.
- Observer le gain de temps lors de l'exécution parallèle avec `Task.WhenAll`.
- Utiliser l'interface `IDisposable` et l'instruction `using var`.

## Consignes

1. **Méthode asynchrone :**
   - Écris la méthode suivante simulant un appel I/O :
     ```csharp
     async Task<string> ChargerDonneesAsync(int serviceId, int delaiMs)
     {
         await Task.Delay(delaiMs);
         return $"Résultat du service {serviceId} (délai : {delaiMs}ms)";
     }
     ```

2. **Comparatif séquentiel vs parallèle :**
   - Instancie un chronomètre via `var sw = System.Diagnostics.Stopwatch.StartNew();`.
   - Exécute trois appels séquentiels (chacun avec un délai de 1 000 ms) en attendant chacun avec `await`. Arrête le chronomètre et affiche le temps écoulé (attendu : ~3 000 ms).
   - Réinitialise le chronomètre (`sw.Restart();`).
   - Déclenche les trois appels simultanément en stockant les `Task` dans un tableau, puis attends leur complétion avec `await Task.WhenAll(...)`. Affiche le temps écoulé (attendu : ~1 000 ms).

3. **Gestion déterministe des ressources (`IDisposable`) :**
   - Déclare une classe `FichierTemporaire` qui implémente l'interface `IDisposable`.
   - Dans la méthode `Dispose()`, affiche : `"[DISPOSE] Ressource libérée avec succès"`.
   - Dans le corps du programme, utilise la classe avec `using var f = new FichierTemporaire();`.
   - Place des `Console.WriteLine(...)` avant et après pour vérifier à quel moment précis `Dispose()` est exécuté.