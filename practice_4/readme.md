# Module 4 — Injection de dépendances manuelle

## Objectifs
- Comprendre le principe d'Inversion de Contrôle (IoC).
- Découpler une classe métier d'une implémentation concrète en s'appuyant sur une interface.

## Consignes

1. **Définition du contrat :**
   - Crée l'interface suivante :
     ```csharp
     public interface INotificationSender
     {
         void Envoyer(string destinataire, string message);
     }
     ```

2. **Implémentations concrètes :**
   - Crée la classe `EmailNotificationSender` implémentant `INotificationSender` :
     - Affiche en console : `$"[EMAIL] Destinataire: {destinataire} | Message: {message}"`.
   - Crée la classe `SmsNotificationSender` implémentant `INotificationSender` :
     - Affiche en console : `$"[SMS] Numéro: {destinataire} | Message: {message}"`.

3. **Classe consommatrice (injection par constructeur) :**
   - Crée une classe `CommandeService`.
   - Déclare un champ privé en lecture seule : `private readonly INotificationSender _sender;`.
   - Reçois `INotificationSender` en paramètre de son constructeur et affecte-le au champ.
   - Ajoute une méthode `ValiderCommande(string client)` qui simule une validation et appelle `_sender.Envoyer(client, "Votre commande a été validée.");`.

4. **Assemblage dans `Program.cs` :**
   - Instancie un `CommandeService` auquel tu injectes une instance de `EmailNotificationSender`. Appelle `ValiderCommande("alice@example.com")`.
   - Instancie un second `CommandeService` auquel tu injectes une instance de `SmsNotificationSender`. Appelle `ValiderCommande("+33612345678")`.
   - Constate que la classe `CommandeService` n'a pas eu besoin d'être modifiée pour changer de canal d'envoi.